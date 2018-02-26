using Auto.Test.Framework.BrowserDrivers;
using Auto.Test.Framework.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2BMage.Test.Pages
{
    public class LoginPageElements: BasePageElements
    {
        public IWebElement UserName
        {
            get
            {
                return WebDriver.FindElement(By.Id("UserName"));
            }
        }
        public IWebElement Password
        {
            get
            {
                return WebDriver.FindElement(By.Id("Password"));
            }
        }

        public IWebElement Signin
        {
            get {
                return WebDriver.FindElement(By.CssSelector("#login div:nth-of-type(3) div:nth-of-type(2) button.btn.blue"));
            }
        }
    }
}
