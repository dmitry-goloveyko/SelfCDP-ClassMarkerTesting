using System;
using System.Configuration;
using OpenQA.Selenium;

namespace ClassMarkerTesting.Core
{
    public class Browser
    {
        private static IWebDriver driver;

        private Browser()
        {
        }

        public static IWebDriver BrowserDriver
        {
            get
            {
                if (driver == null)
                {
                    driver = BrowserFactory.GetBrowser();
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings.Get("Timeout"))));
                    driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings.Get("Timeout"))));
                    driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings.Get("Timeout"))));
                }

                return driver;
            }
        }
    }
}
