using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Models;
using System;
using System.Windows.Forms;

namespace SIPETIK_PBO_A7.View
{
    public partial class V_Register : Form
    {
        usercontroller uc = new usercontroller();

        public V_Register()
        {
            InitializeComponent();
        }

        private bool ValidateRegisterInput()
        {
            if (string.IsNullOrWhiteSpace(tbnama.Text))
            {
                MessageBox.Show("Nama wajib diisi.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbemail.Text))
            {
                MessageBox.Show("Email wajib diisi.");
                return false;
            }

            if (!tbemail.Text.Contains("@"))
            {
                MessageBox.Show("Format email tidak valid.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbpassword.Text))
            {
                MessageBox.Show("Password wajib diisi.");
                return false;
            }

            if (tbpassword.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter.");
                return false;
            }

            if (konpassword.Text != tbpassword.Text)
            {
                MessageBox.Show("Konfirmasi password tidak cocok.");
                return false;
            }

            return true;
        }

        private User GetRegisterRequest()
        {
            return new User
            {
                Nama = tbnama.Text.Trim(),
                Email = tbemail.Text.Trim(),
                Password = tbpassword.Text.Trim(),
                IsAdmin = false
            };
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            if (!ValidateRegisterInput())
                return;

            var user = GetRegisterRequest();
            bool hasil = uc.Register(user);

            if (hasil)
            {
                MessageBox.Show("Registrasi berhasil! Silakan login.");
                new SIPETIK_PBO_A7.V_Login().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registrasi gagal. Email mungkin sudah dipakai.");
            }
        }
    }
}
