using System;
using System.Configuration;
using ClassMarkerTesting.Core.BrowserInitializer;
using OpenQA.Selenium;

namespace ClassMarkerTesting.Core
{
    public static class BrowserFactory
    {
        public static IWebDriver GetBrowser()
        {
            var browser = ConfigurationManager.AppSettings["Browser"];

            switch (browser)
            {
                case "Firefox":
                    return new FirefoxInitializer().Initialize();
                case "Chrome":
                    return new ChromeInitializer().Initialize();
                default:
                    throw new Exception("Unrecognizable Browser value in App.Config");
            }
        }
    }
}
