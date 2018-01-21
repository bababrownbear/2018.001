using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.BusinessLayer
{
    public interface ISessionBusiness
    {
        bool RefreshSession(Guid Token);

        Guid Login(string Username);
    }
}
