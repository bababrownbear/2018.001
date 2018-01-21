using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.BusinessLayer
{
    public class SessionBusiness : ISessionBusiness
    {
        public bool RefreshSession(Guid Token)
        {
            return true;
        }

        public Guid Login(string Username)
        {
            return Guid.NewGuid();
        }
    }
}
