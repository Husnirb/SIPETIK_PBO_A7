using Npgsql;
using SIPETIK_PBO_A7.Database;
using SIPETIK_PBO_A7.Models;
using System;
using System.Windows.Forms;

namespace SIPETIK_PBO_A7.Controllers
{
    public class TiketController
    {
        private readonly DbContext dbContext;

        public TiketController()
        {
            dbContext = new DbContext();
        }

        public Tiket GetTiket()
        {
            try
            {
                using var conn = new NpgsqlConnection(dbContext.ConnStr);
                conn.Open();

                string query = @"SELECT tiket_id, nama_tiket, harga, stok
                                 FROM public.tiket
                                 ORDER BY tiket_id ASC
                                 LIMIT 1";

                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Tiket
                    {
                        TiketId = reader.GetInt32(reader.GetOrdinal("tiket_id")),
                        NamaTiket = reader.GetString(reader.GetOrdinal("nama_tiket")),
                        Harga = reader.GetInt32(reader.GetOrdinal("harga")),
                        Stok = reader.GetInt32(reader.GetOrdinal("stok"))
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GET TIKET ERROR: {ex.Message}");
                return null;
            }
        }

        public bool TambahStok(int jumlah)
        {
            try
            {
                using var conn = new NpgsqlConnection(dbContext.ConnStr);
                conn.Open();

                string query = @"UPDATE public.tiket SET stok = stok + @qty";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@qty", jumlah);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"TAMBAH STOK ERROR: {ex.Message}");
                return false;
            }
        }
    }
}
