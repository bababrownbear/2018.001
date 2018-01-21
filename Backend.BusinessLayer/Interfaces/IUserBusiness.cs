using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.BusinessLayer
{
    public interface IUserBusiness
    {
        bool GetUserByUsername(string Username);

        bool IsValidPassword(string Username, string Password);
    }
}
