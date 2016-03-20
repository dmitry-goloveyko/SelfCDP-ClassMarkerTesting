using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ClassMarkerTesting.Tests
{
    public class BaseTest
    {
        public IWebDriver Browser
        {
            get { return Core.Browser.BrowserDriver; }
        }

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            Browser.Manage().Window.Maximize();
        }

        [SetUp]
        public void SetUp()
        {
            Browser.Navigate().GoToUrl(ConfigurationManager.AppSettings["ApplicationUrl"]);
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            Browser.Close();
        }
    }
}
