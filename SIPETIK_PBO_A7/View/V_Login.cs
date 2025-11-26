using Npgsql;
using SIPETIK_PBO_A7.Controllers;
using SIPETIK_PBO_A7.Database;
using SIPETIK_PBO_A7.Helper;
using SIPETIK_PBO_A7.View;

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
            var res = uc.login(tbemail.Text.Trim(), tbpassword.Text);

            if (res.sukses)
            {
                MessageBox.Show($"login berhasil. halo, {res.nama}!");
            }
            else
            {
                MessageBox.Show(res.pesan);
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
