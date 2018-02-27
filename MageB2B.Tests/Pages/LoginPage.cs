using Auto.Test.Framework.BrowserDrivers;
using Auto.Test.Framework.PageObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2BMage.Test.Pages
{
    public class LoginPage : BasePageObject<LoginPageElements, LoginPageAssert>
    {
        public LoginPage(IBrowserDriver browserDriver) :base(browserDriver)
        {
            
        }

        public void Login(string email,string password)
        {
            Navigate();
            Elements.Email.SendKeys(email);
            Elements.Pass.SendKeys(password);
            Elements.Signin.Click();
            Asserts.Validate("My Dashboard");

           // Elements.
        }
        public override void Navigate(string part = "customer/account/login/")
        {
            base.Navigate(part);
        }

    }
}
