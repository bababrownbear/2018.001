using Backend.BusinessLayer.LoginBusiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Backend.UnitTests
{
    [TestClass]
    public class LoginBusinessTests
    {
        private LoginBusiness _loginBusiness;

        public LoginBusinessTests()
        {
            LoginBusiness loginBusiness = new LoginBusiness();

            _loginBusiness = loginBusiness;
        }
    
        [TestMethod]
        public void ShouldGetUserByUsername()
        {
            var result = _loginBusiness.GetUserByUsername("test");

            Assert.IsTrue(result);
        }
    }
}
