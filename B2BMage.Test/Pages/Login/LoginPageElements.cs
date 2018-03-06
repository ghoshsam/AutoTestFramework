using Auto.Test.Framework;
using OpenQA.Selenium;

namespace B2BMage.Test.Pages
{
    public class LoginPageElements: BasePageElements
    {
        public IWebElement Email
        {
            get
            {
                return WebDriver.FindElement(By.Id("email"));
            }
        }
        public IWebElement Pass
        {
            get
            {
                return WebDriver.FindElement(By.Id("pass"));
            }
        }

        public IWebElement Signin
        {
            get {
                return WebDriver.FindElement(By.Id("send2"));
            }
        }

        public IWebElement ResultValue
        {
            get {
                return WaitUntilElementExists(By.XPath("//h1[@class='page-title']/span[@class='base']"));
               }
        }
    }
}
