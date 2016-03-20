using OpenQA.Selenium;

namespace ClassMarkerTesting.Core.BrowserInitializer
{
    interface IBrowserInitializable
    {
        IWebDriver Initialize();
    }
}
