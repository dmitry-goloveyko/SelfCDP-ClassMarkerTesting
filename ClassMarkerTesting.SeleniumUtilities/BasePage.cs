using System;
using OpenQA.Selenium.Support.PageObjects;

namespace ClassMarkerTesting.SeleniumUtilities
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Core.Browser.BrowserDriver, this);
        }

        public virtual string Url 
        {
            get { throw new Exception("No URL for page object.");}
        }
    }
}
