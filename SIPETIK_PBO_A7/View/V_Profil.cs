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
    public partial class V_Profil : Form
    {
        private User _user;
        private usercontroller controller;

        public V_Profil(User user)
        {
            InitializeComponent();
            controller = new usercontroller();
            _user = user;
        }

        private void V_Profil_Load(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("User tidak ditemukan.");
                return;
            }

            nama1.Text = _user.Nama;
            nama2.Text = _user.Nama;
            nama3.Text = _user.Nama;
            id_akun.Text = _user.UserId.ToString();
            email.Text = _user.Email;
            password.Text = _user.Password;
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Beranda v_Beranda = new V_Beranda(_user);
            v_Beranda.Show();
        }
    }
}
