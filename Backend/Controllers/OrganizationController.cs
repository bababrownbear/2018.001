using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Produces("application/json")]
    [Route("api/Organization")]
    public class OrganizationController : Controller
    {
        [HttpPost]
        public void Post([FromBody]string value)
        {
             // Validate User as admin user type
            // Create group using group name and number of members allowed in group
            // return groupID

        }

        [HttpGet("{id}")]
        public Organization Get(int OrgID)
        {
            Organization org = new Organization();
            return org;
         //   return Organization[id] ;
        }

        [HttpDelete("{id}")]
        public void Del(int OrgID)
        {
            // call Business layer to del Org[id]
        }

        public void Put(Organization org)
        {
            // stuff
        }

    }
}