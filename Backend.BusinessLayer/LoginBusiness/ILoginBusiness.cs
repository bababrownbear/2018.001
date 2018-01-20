using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.BusinessLayer.LoginBusiness
{
    public interface ILoginBusiness
    {
        bool GetUserByUsername(string Username);
    }
}
