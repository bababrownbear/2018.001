using Backend.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
            var result = _sessionBusiness.RefreshSession("test");

            Assert.IsTrue(result);
        }
    }
}
