using System;
using System.Windows.Forms;
using SIPETIK_PBO_A7.Models;
using SIPETIK_PBO_A7.Helper;

namespace SIPETIK_PBO_A7.View
{
    public partial class TransaksiCard : UserControl
    {
        private Transaksi trx;

        public event Action<Transaksi> DetailClicked;

        public TransaksiCard()
        {
            InitializeComponent();
        }

        public void LoadData(Transaksi t)
        {
            trx = t;

            lblHarga.Text = "Rp " + t.TotalHarga.ToString("N0");
            lblTglTransaksi.Text = t.TanggalTransaksi.ToString("dd MMM yyyy");
            lblStatus.Text = t.StatusTransaksi;
            lblStatus.TextAlign = ContentAlignment.MiddleRight;

            if (UserSession.Instance.CurrentUser.IsAdmin)
            {
                lblNamaUser.Visible = true;
                lblNamaUser.Text = t.NamaUser;
            }
            else
            {
                lblNamaUser.Visible = false;
            }
        }

        private void klikDetail_Click_1(object sender, EventArgs e)
        {
            DetailClicked?.Invoke(trx);
        }
    }
}
