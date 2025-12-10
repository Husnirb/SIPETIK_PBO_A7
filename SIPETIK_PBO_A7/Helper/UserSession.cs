using SIPETIK_PBO_A7.Models;
using System;

namespace SIPETIK_PBO_A7.Helper
{
    public sealed class UserSession
    {
        private static readonly Lazy<UserSession> lazy =
            new Lazy<UserSession>(() => new UserSession());

        public static UserSession Instance => lazy.Value;

        public User CurrentUser { get; private set; }

        private UserSession() { }

        public void SetUser(User user)
        {
            CurrentUser = user;
        }

        public void Clear()
        {
            CurrentUser = null;
        }

        public bool IsLoggedIn => CurrentUser != null;
    }
}
