using Npgsql;
using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Database;
using SIPETIK_PBO_A7.Helper;
using SIPETIK_PBO_A7.View;
using SIPETIK_PBO_A7.Models;

namespace SIPETIK_PBO_A7
{
    public partial class V_Login : Form
    {
        usercontroller uc = new usercontroller();

        public V_Login()
        {
            InitializeComponent();
        }

        private void V_Login_Load(object sender, EventArgs e)
        {

        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Create a User object with the entered email and password
            User user = new User
            {
                Email = tbemail.Text.Trim(),
                Password = tbpassword.Text
            };

            // Call the Login method on usercontroller
            var res = uc.Login(user);

            if (res != null)
            {
                MessageBox.Show($"login berhasil. halo, {res.Nama}!");
            }
            else
            {
                MessageBox.Show("Login gagal. Silakan periksa email dan password Anda.");
            }
        }

        private void lblregister_Click(object sender, EventArgs e)
        {
            V_Register reg = new V_Register();
            reg.Show();
            this.Hide();
        }
    }
}
