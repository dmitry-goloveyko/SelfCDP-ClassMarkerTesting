using System.Configuration;
using ClassMarkerTesting.SeleniumUtilities.PageActions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ClassMarkerTesting.NUnitTests
{
    public class BaseTest
    {
        public IWebDriver Browser
        {
            get { return Core.Browser.BrowserDriver; }
        }

        [SetUp]
        public void SetUp()
        {
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl(ConfigurationManager.AppSettings["ApplicationUrl"]);
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Close();
        }
    }
}
