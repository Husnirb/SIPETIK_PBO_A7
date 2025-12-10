using System;
using System.Windows.Forms;
using SIPETIK_PBO_A7.Models;
using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Helper;

namespace SIPETIK_PBO_A7.View
{
    public partial class V_DetailTransaksi : Form
    {
        private Transaksi trx;
        private readonly TransaksiController tc;

        public V_DetailTransaksi(Transaksi transaksi)
        {
            InitializeComponent();
            trx = transaksi;
            tc = new TransaksiController();

            LoadDetail();
            ModeAdmin();
        }

        private void LoadDetail()
        {
            lblidtransaksi.Text = trx.TransaksiId.ToString();
            lbljumlah.Text = trx.Kuantitas.ToString();
            lbltotalharga.Text = "Rp " + trx.TotalHarga.ToString("N0");
            lbltanggal.Text = trx.TanggalTransaksi.ToString("dd MMM yyyy");

            lblstatus.Text = trx.StatusTransaksi;
            lblstatus.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void ModeAdmin()
        {
            if (UserSession.Instance.CurrentUser != null &&
                UserSession.Instance.CurrentUser.IsAdmin)
            {
                btnUbahStatus.Visible = true;
            }
            else
            {
                btnUbahStatus.Visible = false;
            }
        }

        private void btnUbahStatus_Click(object sender, EventArgs e)
        {
            var tanya = MessageBox.Show(
                "Apakah Anda yakin ingin mengubah status transaksi ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (tanya == DialogResult.No)
                return;

            string current = trx.StatusTransaksi.Trim().ToLower();

            string statusBaru = current == "belum_terkonfirmasi"
                ? "dikonfirmasi"
                : "belum_terkonfirmasi";

            bool ok = tc.UpdateStatusTransaksi(trx.TransaksiId, statusBaru);

            if (ok)
            {
                trx.StatusTransaksi = statusBaru;
                lblstatus.Text = statusBaru;
                MessageBox.Show("Status berhasil diperbarui.");
            }
            else
            {
                MessageBox.Show("Gagal memperbarui status.");
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
