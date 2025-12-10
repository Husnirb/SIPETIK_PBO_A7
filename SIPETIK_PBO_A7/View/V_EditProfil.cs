using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Models;
using System;
using System.Windows.Forms;

namespace SIPETIK_PBO_A7.View
{
    public partial class V_EditProfil : Form
    {
        private User _user;
        private usercontroller controller;

        public V_EditProfil(User user)
        {
            InitializeComponent();
            _user = user;
            controller = new usercontroller();

            tbNama.Text = _user.Nama;
            tbEmail.Text = _user.Email;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Edit profil harus diselesaikan terlebih dahulu",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        private void klikBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void klikSimpan_Click(object sender, EventArgs e)
        {
            string namaBaru = tbNama.Text.Trim();
            string emailBaru = tbEmail.Text.Trim();

            // Validasi input
            if (string.IsNullOrWhiteSpace(namaBaru) || string.IsNullOrWhiteSpace(emailBaru))
            {
                MessageBox.Show("Nama dan Email tidak boleh kosong!",
                    "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi email sederhana
            if (!emailBaru.Contains("@") || !emailBaru.Contains("."))
            {
                MessageBox.Show("Format email tidak valid!",
                    "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update ke database lewat controller
            bool updateBerhasil = controller.UpdateUser(_user.UserId, namaBaru, emailBaru);

            if (updateBerhasil)
            {
                MessageBox.Show("Profil berhasil diperbarui!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // beri tahu V_Profil bahwa penyimpanan berhasil
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui profil.", "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
