using ClassMarkerTesting.SeleniumUtilities.PageActions;
using NUnit.Framework;

namespace ClassMarkerTesting.NUnitTests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        [Test]
        public void LoginTest()
        {
            new IndexPageActions().Login(Role.User);
            //push
            //new
            //new2
        }
    }
}
