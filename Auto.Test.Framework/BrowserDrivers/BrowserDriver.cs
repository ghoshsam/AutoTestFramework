using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.BrowserDrivers
{
    public interface IBrowserDriver
    {
        IWebDriver WebDriver { get; set; }
        WebDriverWait DriverWait { get;}
        void InitDriver();
        void CleanUp();
    }
    public class BrowserDriver<TWebDriver>: IBrowserDriver, IDisposable
         where TWebDriver : IWebDriver, new()
    {
        private IWebDriver _webDriver;
        private WebDriverWait _webDriverWait;


        // private static BrowserDriver _instance=null;
        //public BrowserDriver(BrowserTypes browserTypes=BrowserTypes.Chrome,int defaultTimeOut=30)
        //{

        //    InitDriver(browserTypes, defaultTimeOut);
        //}

       
        public void InitDriver()
        {
            

            switch (typeof(TWebDriver).Name)
            {
                case "ChromeDriver":
                    _webDriver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
                    break;
                case "FirefoxDriver":
                    _webDriver = new FirefoxDriver();
                    break;
                case "InternetExplorer":
                    break;
            }
            
            _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
        }
        private void InitDriver(BrowserTypes browserTypes = BrowserTypes.Chrome, int defaultTimeOut = 30)
        {
            switch (browserTypes)
            {
                case BrowserTypes.Chrome:
                    _webDriver = new ChromeDriver();
                    break;
                case BrowserTypes.Firefox:
                    _webDriver = new FirefoxDriver();
                    break;
                case BrowserTypes.InternetExplorer:
                    break;   
            }
            _webDriverWait = new WebDriverWait(_webDriver,TimeSpan.FromSeconds(defaultTimeOut));
        }
        public IWebDriver WebDriver
        {
            get
            {
                if (_webDriver == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return _webDriver;
            }
            set { _webDriver = value; }
        }

        public WebDriverWait DriverWait
        {
            get
            {
                if (_webDriverWait == null)
                {
                    throw new NullReferenceException("The WebDriver wait instance was not initialized.");
                }
                return _webDriverWait;
            }
        }
        public void CleanUp()
        {
            _webDriver.Quit();
            _webDriver = null;
            _webDriverWait = null;
        }

        public void Dispose()
        {
            _webDriver.Quit();
            _webDriver = null;
            _webDriverWait = null;
        }
    }

    public enum BrowserTypes
    {
        Chrome,
        InternetExplorer,
        Firefox,
        NotSet
    }
}
