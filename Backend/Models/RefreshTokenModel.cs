using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class RefreshTokenModel
    {
        public string Token { get; set; }

        public Guid GetTokenAsGuid()
        {
            return Guid.Parse(Token);
        }

    }
}
