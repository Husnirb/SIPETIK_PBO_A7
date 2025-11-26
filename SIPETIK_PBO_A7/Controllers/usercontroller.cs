using Npgsql;
using SIPETIK_PBO_A7.Database;
using SIPETIK_PBO_A7.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPETIK_PBO_A7.Controllers
{
    public class usercontroller
    {
        private readonly string connstr;

        public usercontroller()
        {
            DbContext db = new DbContext();
            connstr = db.connStr;
        }

        public string register(string nama, string email, string password, string telp)
        {
            // validasi
            if (nama == "" || email == "" || password == "" || telp == "")
                return "semua field wajib diisi!";

            if (!email.Contains("@") || !email.Contains("."))
                return "format email tidak valid!";

            if (password.Length < 6)
                return "password minimal 6 karakter!";

            string hash = Security.HashPassword(password);

            try
            {
                using (var conn = new NpgsqlConnection(connstr))
                {
                    conn.Open();

                    // cek email
                    string cek = "select count(*) from users where email=@e";
                    using (var cmdcek = new NpgsqlCommand(cek, conn))
                    {
                        cmdcek.Parameters.AddWithValue("@e", email);
                        long sudahada = (long)cmdcek.ExecuteScalar();
                        if (sudahada > 0)
                            return "email sudah terdaftar!";
                    }

                    // insert user
                    string q = "insert into users(nama,email,password,is_admin) values (@n,@e,@p,false)";
                    using (var cmd = new NpgsqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", nama);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@p", hash);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "ok";
            }
            catch (Exception ex)
            {
                return "gagal register: " + ex.Message;
            }
        }

        public (bool sukses, string pesan, int userid, string nama, bool isadmin) login(string email, string password)
        {
            if (email == "" || password == "")
                return (false, "email & password wajib diisi!", 0, "", false);

            string hash = Security.HashPassword(password);

            try
            {
                using (var conn = new NpgsqlConnection(connstr))
                {
                    conn.Open();

                    string q = "select user_id, nama, is_admin from users where email=@e and password=@p";
                    using (var cmd = new NpgsqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@p", hash);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userid = reader.GetInt32(0);
                                string nama = reader.GetString(1);
                                bool isadmin = reader.GetBoolean(2);
                                return (true, "ok", userid, nama, isadmin);
                            }
                        }
                    }
                }

                return (false, "email atau password salah!", 0, "", false);
            }
            catch (Exception ex)
            {
                return (false, "gagal login: " + ex.Message, 0, "", false);
            }
        }
    }
}
