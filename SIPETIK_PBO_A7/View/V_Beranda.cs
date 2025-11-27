using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPETIK_PBO_A7.Models;

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
        public V_Beranda()
        {
            InitializeComponent();
        }

        private void btnpesantiket_Click(object sender, EventArgs e)
        {
            V_Tiket tiket = new V_Tiket(_user);
            tiket.FormClosed += (s, args) => this.Close();
            this.Hide();
            tiket.Show();
        }
    }
}
