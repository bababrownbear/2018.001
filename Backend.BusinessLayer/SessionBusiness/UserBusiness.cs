using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.BusinessLayer
{
    public class UserBusiness : IUserBusiness
    {
        public bool GetUserByUsername(string Username)
        {
            return true;
        }

        public bool IsValidPassword(string Username, string Password)
        {
            return true;
        }
    }
}
