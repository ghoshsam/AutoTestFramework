using Auto.Test.Framework.BrowserDrivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.PageObject
{
    public class BasePageElements
    {
        public IWebDriver WebDriver { get; set; }       

        public BasePageElements()
        {          
        }

        public void SwitchToDefault()
        {
            WebDriver.SwitchTo().DefaultContent();
        }
    }
}
