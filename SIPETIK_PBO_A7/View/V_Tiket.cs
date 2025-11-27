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
    public partial class V_Tiket : Form
    {
        private User _user;
        public V_Tiket(User user)
        {
            InitializeComponent();
            _user = user;
        }
        public V_Tiket()
        {
            InitializeComponent();
        }
        private void V_Tiket_Load(object sender, EventArgs e)
        {
            if (_user != null)
            {

            }
        }
    }
}
