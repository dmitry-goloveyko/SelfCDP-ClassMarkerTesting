﻿using System.Linq;
using ClassMarkerTesting.SeleniumUtilities.Pages;
using ClassMarkerTesting.Utilities;

namespace ClassMarkerTesting.SeleniumUtilities.PageActions
{
    public enum Role
    {
        Admin,
        User
    }

    public class IndexPageActions : BasePageActions
    {
        public void Login(Role role)
        {
            var user = 
                role == Role.Admin 
                ? UserUtils.Admins.First() 
                : UserUtils.Users.First();

            var homePage = new IndexPage();

            homePage.LoginInput.Clear();
            homePage.LoginInput.SendKeys(user.Login);
            homePage.Password.Clear();
            homePage.Password.SendKeys(user.Password);
            homePage.LoginButton.Click();
            
            Browser.WaitReadyState();
        }
    }
}
