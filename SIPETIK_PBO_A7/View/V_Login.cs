using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Helper;
using SIPETIK_PBO_A7.Models;
using System;
using System.Windows.Forms;

namespace SIPETIK_PBO_A7
{
    public partial class V_Login : Form
    {
        usercontroller uc = new usercontroller();

        public V_Login()
        {
            InitializeComponent();
        }

        private bool ValidateLoginInput()
        {
            if (string.IsNullOrWhiteSpace(tbemail.Text) ||
                string.IsNullOrWhiteSpace(tbpassword.Text))
            {
                MessageBox.Show("Email dan password wajib diisi.");
                return false;
            }
            return true;
        }

        private User GetLoginRequest()
        {
            return new User
            {
                Email = tbemail.Text.Trim(),
                Password = tbpassword.Text.Trim()
            };
        }

        private bool HandleLoginResult(User user)
        {
            if (user == null)
            {
                MessageBox.Show("Login gagal. Email atau password salah.");
                return false;
            }

            UserSession.Instance.SetUser(user);
            MessageBox.Show($"Login berhasil. Halo {user.Nama}!");
            return true;
        }

        private void RedirectAfterLogin(User user)
        {
            Form next = new SIPETIK_PBO_A7.View.V_Beranda(user);
            next.FormClosed += (s, args) => this.Close();
            this.Hide();
            next.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!ValidateLoginInput())
                return;

            var req = GetLoginRequest();
            var result = uc.Login(req);

            if (!HandleLoginResult(result))
                return;

            RedirectAfterLogin(result);
        }

        private void lblregister_Click(object sender, EventArgs e)
        {
            new SIPETIK_PBO_A7.View.V_Register().Show();
            this.Hide();
        }

        private void V_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
