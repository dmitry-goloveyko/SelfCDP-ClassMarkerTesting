using OpenQA.Selenium;

namespace ClassMarkerTesting.SeleniumUtilities.PageActions
{
    public class BasePageActions
    {
        public IWebDriver Browser
        {
            get { return Core.Browser.BrowserDriver; }
        }
    }
}
