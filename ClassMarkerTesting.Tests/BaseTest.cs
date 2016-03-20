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
