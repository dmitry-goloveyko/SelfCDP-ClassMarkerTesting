using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassMarkerTesting.Core.BrowserInitializer
{
    public class ChromeInitializer : IBrowserInitializable
    {
        public IWebDriver Initialize()
        {
            return new ChromeDriver();
        }
    }
}
