using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Helper;
using SIPETIK_PBO_A7.Models;

namespace SIPETIK_PBO_A7.View
{
    public partial class V_Transaksi : Form
    {
        private readonly TransaksiController tc;

        public V_Transaksi()
        {
            InitializeComponent();
            tc = new TransaksiController();
            LoadTransaksi();
        }

        private void LoadTransaksi()
        {
            var user = UserSession.Instance.CurrentUser;
            if (user == null)
                return;

            List<Transaksi> list;

            if (user.IsAdmin)
                list = tc.GetAllTransaksi();
            else
                list = tc.GetTransaksiByUser(user.UserId);

            flpTransaksi.Controls.Clear();
            flpTransaksi.WrapContents = true;
            flpTransaksi.FlowDirection = FlowDirection.LeftToRight;
            flpTransaksi.AutoScroll = true;
            flpTransaksi.Margin = new Padding(0);
            flpTransaksi.Padding = new Padding(8);

            foreach (var trx in list)
            {
                var card = new TransaksiCard();
                card.Width = 442;
                card.Height = 96;
                card.Margin = new Padding(8, 5, 8, 5);

                card.LoadData(trx);

                card.DetailClicked += (t) =>
                {
                    new V_DetailTransaksi(t).ShowDialog();
                };

                flpTransaksi.Controls.Add(card);
            }
        }

        private void klikBeranda_Click(object sender, EventArgs e)
        {
            var user = UserSession.Instance.CurrentUser;
            V_Beranda vb = new V_Beranda(user);
            vb.FormClosed += (s, args) =>
            {
                if (!AppState.IsLoggingOut)
                    this.Show();
            };
            this.Hide();
            vb.Show();
        }

        private void klikTiket_Click(object sender, EventArgs e)
        {
            var user = UserSession.Instance.CurrentUser;
            V_Tiket vt = new V_Tiket(user);
            vt.FormClosed += (s, args) => this.Show();
            this.Hide();
            vt.Show();
        }

        private void klikprofil_Click(object sender, EventArgs e)
        {
            var user = UserSession.Instance.CurrentUser;
            V_Profil vp = new V_Profil(user);
            vp.FormClosed += (s, args) =>
            {
                if (!AppState.IsLoggingOut)
                    this.Show();
            };
            this.Hide();
            vp.Show();
        }
    }
}
