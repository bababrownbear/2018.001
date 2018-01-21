using Backend.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Backend.UnitTests
{
    [TestClass]
    public class SessionBusinessTests
    {
        private SessionBusiness _sessionBusiness;

        public SessionBusinessTests()
        {
            SessionBusiness sessionBusiness = new SessionBusiness();

            _sessionBusiness = sessionBusiness;
        }
    
        [TestMethod]
        public void ShouldRefreshSession()
        {
            var result = _sessionBusiness.RefreshSession(Guid.NewGuid());

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnTokenAfterLoggingIn()
        {
            var result = _sessionBusiness.Login(It.IsAny<string>());

            Assert.IsInstanceOfType(result,typeof(Guid));
        }
    }
}
