using Npgsql;
using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Database;
using SIPETIK_PBO_A7.Helper;
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
    public partial class V_Register : Form
    {
        usercontroller uc = new usercontroller();

        public V_Register()
        {
            InitializeComponent();
        }

        private void btndaftar_Click(object sender, EventArgs e)
        {
            string hasil = uc.register(
                tbnama.Text.Trim(),
                tbemail.Text.Trim(),
                tbpassword.Text,
                tbtelp.Text.Trim()
            );

            if (hasil == "ok")
            {
                MessageBox.Show("register berhasil! silakan login.");
                V_Login log = new V_Login();
                log.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(hasil);
            }
        }
    }
}
