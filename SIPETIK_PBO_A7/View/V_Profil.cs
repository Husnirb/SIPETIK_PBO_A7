using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Helper;
using SIPETIK_PBO_A7.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPETIK_PBO_A7.View
{
    public partial class V_Profil : Form
    {
        private User _user;
        private usercontroller controller;

        public V_Profil(User user)
        {
            InitializeComponent();
            controller = new usercontroller();
            _user = user;
        }

        private void V_Profil_Load(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("User tidak ditemukan.");
                return;
            }

            nama1.Text = _user.Nama;
            nama2.Text = _user.Nama;
            id_akun.Text = _user.UserId.ToString();
            email.Text = _user.Email;
        }



        private void klikBeranda_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Beranda v_Beranda = new V_Beranda(_user);
            v_Beranda.Show();
        }

        private void klikTiket_Click(object sender, EventArgs e)
        {
            V_Tiket tiket = new V_Tiket(_user);
            tiket.FormClosed += (s, args) => this.Close();
            this.Hide();
            tiket.Show();
        }

        private void kliklogout_Click(object sender, EventArgs e)
        {
            AppState.IsLoggingOut = true;
            UserSession.Instance.Clear();

            V_Login login = new V_Login();
            login.Show();
            this.Hide();
        }

        private void klikTransaksi_Click(object sender, EventArgs e)
        {
            var vt = new V_Transaksi();
            vt.FormClosed += (s, args) => this.Show();
            this.Hide();
            vt.Show();
        }

        private void klikEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_EditProfil edit = new V_EditProfil(_user);
            var result = edit.ShowDialog();
            this.Show();

            if (result == DialogResult.OK)
            {
                _user = controller.GetUserById(_user.UserId);

                nama1.Text = _user.Nama;
                nama2.Text = _user.Nama;
                email.Text = _user.Email;

                MessageBox.Show("Profil berhasil diperbarui!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
