using System;
using Auto.Test.Framework.BrowserDrivers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Auto.Test.Framework
{
    public class BaseTest<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        protected IBrowserDriver BrowserDriver { get; private set; }
        [OneTimeSetUp]
        public void Setup()
        {
            BrowserDriver = new BrowserDriver<TWebDriver>();
            BrowserDriver.InitDriver();
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            BrowserDriver.CleanUp();
        }
    }
}
