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

        public IWebElement WaitUntilElementExists(By by,int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementExists(by));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + by + "' was not found in current context page.");
                throw;
            }
        }
        public void SwitchToDefault()
        {
            WebDriver.SwitchTo().DefaultContent();
        }
    }
}
