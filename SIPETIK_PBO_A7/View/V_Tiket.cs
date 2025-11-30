using System;
using System.Windows.Forms;
using SIPETIK_PBO_A7.Models;
using SIPETIK_PBO_A7.Controllers;

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
        }

        public V_Tiket()
        {
            InitializeComponent();
            tiketcontroller = new TiketController();
            transaksicontroller = new TransaksiController();
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
            klikJumlah.Value = 1;
        }

        private void klikJumlah_ValueChanged(object sender, EventArgs e)
        {
            if (tiket == null) return;

            int qty = (int)klikJumlah.Value;

            if (qty > tiket.Stok)
            {
                klikJumlah.Value = tiket.Stok;
                qty = tiket.Stok;
            }

        }

        private void klikPesanTiket_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("User belum login!");
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
    }
}
