using Backend.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Backend.UnitTests
{
    [TestClass]
    public class UserBusinessTests
    {
        private UserBusiness _userBusiness;

        public UserBusinessTests()
        {
            UserBusiness userBusiness = new UserBusiness();

            _userBusiness = userBusiness;
        }
    
        [TestMethod]
        public void ShouldGetUserByUsername()
        {
            var result = _userBusiness.GetUserByUsername("test");

            Assert.IsTrue(result);
        }
    }
}
