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

        public void Login()
        {
            Elements.UserName.SendKeys("");
           // Elements.
        }

    }
}
