using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ClassMarkerTesting.SeleniumUtilities.Pages
{
    public class IndexPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "un")]
        public IWebElement LoginInput { get; set; }

        [FindsBy(How = How.Id, Using = "pw")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".login-button")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".login-error")]
        public IWebElement LoginError { get; set; }
    }
}
