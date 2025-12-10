using Npgsql;
using SIPETIK_PBO_A7.Database;
using SIPETIK_PBO_A7.Helper;
using SIPETIK_PBO_A7.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SIPETIK_PBO_A7.Controllers
{
    public class usercontroller
    {
        private DbContext dbcontext;

        public usercontroller()
        {
            dbcontext = new DbContext();
        }

        public User Login(User user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbcontext.ConnStr))
                {
                    conn.Open();
                    string query = @"SELECT * FROM users WHERE email=@e AND password=@p";

                    string hashedPassword = Security.HashPassword(user.Password);

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@e", user.Email);
                        cmd.Parameters.AddWithValue("@p", hashedPassword);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
                                    Nama = reader.GetString(reader.GetOrdinal("nama")),
                                    Email = reader.GetString(reader.GetOrdinal("email")),
                                    IsAdmin = reader.GetBoolean(reader.GetOrdinal("is_admin"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LOGIN ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public bool Register(User user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbcontext.ConnStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO users (nama, email, password, is_admin) VALUES (@n, @e, @p, @a)";

                    string hashedPassword = Security.HashPassword(user.Password);

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", user.Nama);
                        cmd.Parameters.AddWithValue("@e", user.Email);
                        cmd.Parameters.AddWithValue("@p", hashedPassword);
                        cmd.Parameters.AddWithValue("@a", user.IsAdmin);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"REGISTER ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateUser(int userId, string nama, string email)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbcontext.ConnStr))
                {
                    conn.Open();

                    string query = @"UPDATE users 
                             SET nama = @n, email = @e
                             WHERE user_id = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", nama);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@id", userId);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"UPDATE ERROR: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public User GetUserById(int userId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbcontext.ConnStr))
                {
                    conn.Open();

                    string query = @"SELECT * FROM users WHERE user_id = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
                                    Nama = reader.GetString(reader.GetOrdinal("nama")),
                                    Email = reader.GetString(reader.GetOrdinal("email")),
                                    IsAdmin = reader.GetBoolean(reader.GetOrdinal("is_admin"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR GetUserById: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
