using Npgsql;
using SIPETIK_PBO_A7.Database;
using SIPETIK_PBO_A7.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SIPETIK_PBO_A7.Controllers
{
    public class TransaksiController
    {
        private readonly DbContext dbContext;
        private Transaksi currentTransaksi;

        public TransaksiController()
        {
            dbContext = new DbContext();
        }

        public void MulaiTransaksi(int userId, int kuantitas, int hargaPerTiket, int tiketId)
        {
            currentTransaksi = new Transaksi
            {
                UserId = userId,
                TiketId = tiketId,
                Kuantitas = kuantitas,
                TotalHarga = kuantitas * hargaPerTiket,
                StatusTransaksi = "belum_terkonfirmasi",
                TanggalTransaksi = DateTime.Now
            };
        }

        public bool SelesaikanTransaksi()
        {
            if (currentTransaksi == null)
            {
                MessageBox.Show("Tidak ada transaksi yang sedang berjalan.");
                return false;
            }

            try
            {
                using (var conn = new NpgsqlConnection(dbContext.ConnStr))
                {
                    conn.Open();

                    using (var tx = conn.BeginTransaction())
                    {
                        string insert = @"
                            INSERT INTO transaksi 
                                (status_transaksi, kuantitas, total_harga, tanggal_transaksi, tiket_id, user_id)
                            VALUES 
                                (CAST(@status AS public.status_transaksi_enum),
                                 @kuantitas, @total, @tgl, @tiket, @user)
                            RETURNING transaksi_id;
                        ";

                        using (var cmd = new NpgsqlCommand(insert, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@status", currentTransaksi.StatusTransaksi);
                            cmd.Parameters.AddWithValue("@kuantitas", currentTransaksi.Kuantitas);
                            cmd.Parameters.AddWithValue("@total", currentTransaksi.TotalHarga);
                            cmd.Parameters.AddWithValue("@tgl", currentTransaksi.TanggalTransaksi);
                            cmd.Parameters.AddWithValue("@tiket", currentTransaksi.TiketId);
                            cmd.Parameters.AddWithValue("@user", currentTransaksi.UserId);

                            currentTransaksi.TransaksiId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string updateStok = @"UPDATE public.tiket SET stok = stok - @qty";
                        using (var cmd2 = new NpgsqlCommand(updateStok, conn, tx))
                        {
                            cmd2.Parameters.AddWithValue("@qty", currentTransaksi.Kuantitas);
                            cmd2.ExecuteNonQuery();
                        }

                        tx.Commit();
                        currentTransaksi = null;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
                return false;
            }
        }

        public List<Transaksi> GetTransaksiByUser(int userId)
        {
            var list = new List<Transaksi>();

            try
            {
                using (var conn = new NpgsqlConnection(dbContext.ConnStr))
                {
                    conn.Open();

                    string query = @"
                        SELECT transaksi_id, status_transaksi, kuantitas, total_harga, 
                               tanggal_transaksi, tiket_id, user_id
                        FROM transaksi
                        WHERE user_id = @uid
                        ORDER BY tanggal_transaksi DESC
                    ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", userId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new Transaksi
                                {
                                    TransaksiId = reader.GetInt32(reader.GetOrdinal("transaksi_id")),
                                    StatusTransaksi = reader.GetString(reader.GetOrdinal("status_transaksi")),
                                    Kuantitas = reader.GetInt32(reader.GetOrdinal("kuantitas")),
                                    TotalHarga = reader.GetInt32(reader.GetOrdinal("total_harga")),
                                    TanggalTransaksi = reader.GetDateTime(reader.GetOrdinal("tanggal_transaksi")),
                                    TiketId = reader.GetInt32(reader.GetOrdinal("tiket_id")),
                                    UserId = reader.GetInt32(reader.GetOrdinal("user_id"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GET TRANSAKSI ERROR: {ex.Message}");
            }

            return list;
        }

        public bool UpdateStatusTransaksi(int transaksiId, string status)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbContext.ConnStr))
                {
                    conn.Open();

                    string query = @"
                        UPDATE transaksi 
                        SET status_transaksi = CAST(@status AS public.status_transaksi_enum)
                        WHERE transaksi_id = @tid
                    ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@tid", transaksiId);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"UPDATE STATUS ERROR: {ex.Message}");
                return false;
            }
        }

        public Transaksi CurrentTransaksi
        {
            get { return currentTransaksi; }
        }
    }
}
