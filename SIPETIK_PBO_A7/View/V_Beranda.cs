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
    public partial class V_Beranda : Form
    {
        private User _user;

        public V_Beranda(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnpesantiket_Click(object sender, EventArgs e)
        {
            V_Tiket tiket = new V_Tiket(_user);
            tiket.FormClosed += (s, args) => this.Close();
            this.Hide();
            tiket.Show();
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
    }
}
