using Auto.Test.Framework;
using B2BMage.Test.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageB2B.Tests
{
    [TestFixture(typeof(ChromeDriver))]
    public class CustomerLoginTest<TB> : BaseTest<TB>
         where TB : IWebDriver, new()
    {
        [Test]
        public void Login()
        {
            LoginPage loginPage = new LoginPage(BrowserDriver);
            loginPage.Login("samarendra@insync.co.in", "abcd.1234");
        }
    }
}
