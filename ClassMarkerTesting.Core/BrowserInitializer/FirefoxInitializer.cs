using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ClassMarkerTesting.Core.BrowserInitializer
{
    public class FirefoxInitializer : IBrowserInitializable
    {
        public IWebDriver Initialize()
        {
            return new FirefoxDriver();
        }
    }
}
