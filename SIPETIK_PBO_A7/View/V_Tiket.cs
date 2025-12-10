using System;
using System.Windows.Forms;
using SIPETIK_PBO_A7.Models;
using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Helper;

namespace SIPETIK_PBO_A7.View
{
    public partial class V_Tiket : Form
    {
        private User _user;
        private readonly TiketController tiketcontroller;
        private readonly TransaksiController transaksicontroller;
        private Tiket tiket;

        public V_Tiket(User user)
        {
            InitializeComponent();
            _user = user;

            tiketcontroller = new TiketController();
            transaksicontroller = new TransaksiController();

            CekAdmin();
        }

        public V_Tiket()
        {
            InitializeComponent();

            tiketcontroller = new TiketController();
            transaksicontroller = new TransaksiController();

            _user = UserSession.Instance.CurrentUser;
            CekAdmin();
        }

        private void CekAdmin()
        {
            if (_user != null && _user.IsAdmin)
            {
                klikPesanTiket.Visible = false;
                klikJumlah.Visible = false;
                pbjumlah.Visible = false;
            }
        }

        private void V_Tiket_Load(object sender, EventArgs e)
        {
            tiket = tiketcontroller.GetTiket();

            if (tiket == null)
            {
                MessageBox.Show("Tiket tidak tersedia!");
                klikPesanTiket.Enabled = false;
                return;
            }

            klikJumlah.Minimum = 1;
            klikJumlah.Maximum = tiket.Stok;
            klikJumlah.Value = tiket.Stok > 0 ? 1 : 0;

            if (tiket.Stok == 0)
                klikPesanTiket.Enabled = false;
        }

        private void klikJumlah_ValueChanged(object sender, EventArgs e)
        {
            if (tiket == null)
                return;

            if (klikJumlah.Value > tiket.Stok)
                klikJumlah.Value = tiket.Stok;
        }

        private void klikPesanTiket_Click(object sender, EventArgs e)
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

            tiket = tiketcontroller.GetTiket();
            if (tiket == null)
            {
                MessageBox.Show("Tiket tidak tersedia!");
                return;
            }

            int jumlah = (int)klikJumlah.Value;

            if (jumlah > tiket.Stok)
            {
                MessageBox.Show("Stok tiket tidak cukup!");
                return;
            }

            transaksicontroller.MulaiTransaksi(
                _user.UserId,
                jumlah,
                tiket.Harga,
                tiket.TiketId
            );

            V_KodePembayaran v = new V_KodePembayaran(_user, transaksicontroller, tiketcontroller);
            v.FormClosed += (s, args) => this.Close();
            this.Hide();
            v.Show();
        }

        private void klikBeranda_Click(object sender, EventArgs e)
        {
            V_Beranda v = new V_Beranda(_user);
            v.Show();
            this.Close();
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

        private void klikTransaksi_Click(object sender, EventArgs e)
        {
            var vt = new V_Transaksi();
            vt.FormClosed += (s, args) => this.Show();
            this.Hide();
            vt.Show();
        }
    }
}
