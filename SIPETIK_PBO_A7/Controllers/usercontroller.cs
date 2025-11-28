using Npgsql;
using SIPETIK_PBO_A7.Database;
using SIPETIK_PBO_A7.Helper;
using SIPETIK_PBO_A7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    string query = @"
                        SELECT * FROM users 
                        WHERE email = @e AND password = @p";

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
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LOGIN ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public bool Register(User user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbcontext.ConnStr))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO users (nama, email, password, is_admin) 
                        VALUES (@n, @e, @p, @a)";
                    string hashedPassword = Security.HashPassword(user.Password);
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", user.Nama);
                        cmd.Parameters.AddWithValue("@e", user.Email);
                        cmd.Parameters.AddWithValue("@p", hashedPassword);
                        cmd.Parameters.AddWithValue("@a", user.IsAdmin);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"REGISTER ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public User GetProfile(int userId)
        {
            string query = "SELECT user_id, nama, email, password, is_admin FROM users WHERE user_id = @id";
            User user = null;

            try
            {
                using (var conn = new NpgsqlConnection(dbcontext.ConnStr))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var loggedInUser = new User
                                {
                                    UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
                                    Nama = reader.GetString(reader.GetOrdinal("nama")),
                                    Email = reader.GetString(reader.GetOrdinal("email")),
                                    IsAdmin = reader.GetBoolean(reader.GetOrdinal("is_admin")),
                                    Password = reader.GetString(reader.GetOrdinal("password"))
                                };

                                return loggedInUser;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PROFILE ERROR: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return user;
        }
    }
}

        
