using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Backend.BusinessLayer;
using Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class SessionController : Controller
    {
        private ISessionBusiness _sessionBusiness;
        private IUserBusiness _userBusiness;

        public SessionController(ISessionBusiness sessionBusiness, IUserBusiness userBusiness)
        {
            _sessionBusiness = sessionBusiness;
            _userBusiness = userBusiness;
        }

        // get: api/Login
        [HttpPost]
        public HttpResponseMessage RefreshSession([FromBody]RefreshTokenModel refreshTokenModel)
        {
            _sessionBusiness.RefreshSession(refreshTokenModel.GetTokenAsGuid());

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // POST: api/Login
        [HttpPost]
        public HttpResponseMessage Post([FromBody]LoginModel loginModel)
        {
            if(string.IsNullOrEmpty(loginModel.Username) 
                || string.IsNullOrEmpty(loginModel.Password))
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }

            if(_userBusiness.IsValidPassword(loginModel.Username, loginModel.Password))
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

            return new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }
        
        //// PUT: api/Login/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        
        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
