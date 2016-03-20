using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ClassMarkerTesting.SeleniumUtilities.Pages
{
    public class UserPage : HomeBasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".sf-menu ul li")] 
        public List<IWebElement> Tabs;
    }
}
