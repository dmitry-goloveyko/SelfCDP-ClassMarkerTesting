using System;
using ClassMarkerTesting.SeleniumUtilities.PageActions;
using NUnit.Framework;

namespace ClassMarkerTesting.Tests
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        [Test]
        public void LoginTest()
        {
            Console.WriteLine("LoginTest launched");
            new IndexPageActions().Login(Role.User);
        }
    }
}
