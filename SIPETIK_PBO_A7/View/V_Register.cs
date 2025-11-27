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
using SIPETIK_PBO_A7.Models;

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
            var user = new User
            {
                Nama = tbnama.Text.Trim(),
                Email = tbemail.Text.Trim(),
                Password = tbpassword.Text,
            };

            bool hasil = uc.Register(user);

            if (hasil)
            {
                MessageBox.Show("register berhasil! silakan login.");
                V_Login log = new V_Login();
                log.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Register gagal. Silakan coba lagi.");
            }
        }
    }
}
