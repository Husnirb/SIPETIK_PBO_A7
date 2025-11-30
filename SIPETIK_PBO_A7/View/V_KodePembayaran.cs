using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Models;
using System;
using System.Windows.Forms;

namespace SIPETIK_PBO_A7.View
{
    public partial class V_KodePembayaran : Form
    {
        private User _user;
        private readonly TransaksiController transaksicontroller;
        private readonly TiketController tiketcontroller;

        private Tiket tiket;
        private Transaksi transaksi;

        public V_KodePembayaran(User user, TransaksiController transaksiCtrl, TiketController tiketCtrl)
        {
            InitializeComponent();
            _user = user;
            transaksicontroller = transaksiCtrl;
            tiketcontroller = tiketCtrl;
        }

        public V_KodePembayaran(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void V_KodePembayaran_Load(object sender, EventArgs e)
        {
            tiket = tiketcontroller.GetTiket();
            transaksi = transaksicontroller.CurrentTransaksi;

            if (tiket == null || transaksi == null)
            {
                MessageBox.Show("Data transaksi tidak ditemukan!");
                this.Close();
                return;
            }

            lblTotalTiket.Text = transaksi.Kuantitas.ToString();
            lblTotalHarga.Text = transaksi.TotalHarga.ToString("N0");
        }

        private void klikBeranda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Transaksi harus diselesaikan terlebih dahulu",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        private void klikSelesai_Click(object sender, EventArgs e)
        {
            transaksicontroller.SelesaikanTransaksi();

            MessageBox.Show("Pembayaran berhasil! Transaksi tersimpan.");

            V_Beranda vBeranda = new V_Beranda(_user);
            vBeranda.Show();
            this.Close();
        }
    }
}
