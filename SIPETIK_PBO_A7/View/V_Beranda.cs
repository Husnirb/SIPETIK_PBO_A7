using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Helper;
using SIPETIK_PBO_A7.Models;
using System;
using System.Windows.Forms;

namespace SIPETIK_PBO_A7.View
{
    public partial class V_Beranda : Form
    {
        private User _user;

        public V_Beranda(User user)
        {
            InitializeComponent();
            _user = user;

            if (_user != null && _user.IsAdmin)
            {
                btnpesantiket.Visible = false;
                btnpesantiket.Enabled = false;
            }
        }

        private void klikprofil_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("User belum login!");
                return;
            }

            V_Profil vp = new V_Profil(_user);
            vp.Show();
            this.Hide();
        }

        private void klikTiket_Click(object sender, EventArgs e)
        {
            V_Tiket tiket = new V_Tiket(_user);
            tiket.FormClosed += (s, args) => this.Close();
            this.Hide();
            tiket.Show();
        }

        private void klikTransaksi_Click(object sender, EventArgs e)
        {
            var vt = new V_Transaksi();
            vt.FormClosed += (s, args) => this.Show();
            this.Hide();
            vt.Show();
        }

        private void btnpesantiket_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("User belum login!");
                return;
            }

            if (_user.IsAdmin)
            {
                MessageBox.Show("Admin tidak dapat memesan tiket.");
                return;
            }

            V_Tiket tiket = new V_Tiket(_user);
            tiket.FormClosed += (s, args) => this.Close();
            this.Hide();
            tiket.Show();
        }
    }
}
