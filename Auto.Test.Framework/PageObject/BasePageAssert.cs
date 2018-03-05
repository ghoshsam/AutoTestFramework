using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Test.Framework.PageObject
{
    public class BasePageAssert<TE> where TE :BasePageElements, new()
    {
        public IWebDriver WebDriver { get; set; }
        public TE Elements
        {
            get => new TE() { WebDriver = WebDriver };
        }
    }
}
