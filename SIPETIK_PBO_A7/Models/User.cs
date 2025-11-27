using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPETIK_PBO_A7.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Is_Admin { get; set; }
        public bool IsAdmin { get; set; }
    }
}
