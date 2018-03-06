using Auto.Test.Framework;
using B2BMage.Test.Behaviours;
using B2BMage.Test.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace B2BMage.Test
{
    [TestFixture(typeof(ChromeDriver))]
    public class CustomerLoginTest<TB>:BaseTest<TB>
         where TB : IWebDriver, new()
    {
        [Test]
        public void LoginSelectProduct()
        {
            LoginPage loginPage = new LoginPage(BrowserDriver);
            loginPage.Login("samarendra@insync.co.in","abcd.1234");
            ProductPage productPage = new ProductPage(BrowserDriver);
            productPage.Navigate();


            //BehaviorDefinitionEngine behaviorDefinitionEngine = new BehaviorDefinitionEngine();
            //behaviorDefinitionEngine.Execute(
            //    new ProductNavigationDefination());
        }
    }
}
