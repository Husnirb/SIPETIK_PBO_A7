using System;

namespace SIPETIK_PBO_A7.Models
{
    public class User
    {
        private int _userId;
        private string _nama;
        private string _email;
        private string _password;
        private bool _isAdmin;

        public int UserId
        {
            get => _userId;
            set => _userId = value;
        }
        public string Nama
        {
            get => _nama;
            set => _nama = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }
        public bool IsAdmin
        {
            get => _isAdmin;
            set => _isAdmin = value;
        }
    }
}
