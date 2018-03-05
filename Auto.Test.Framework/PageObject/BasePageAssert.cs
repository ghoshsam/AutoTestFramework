using OpenQA.Selenium;

namespace Auto.Test.Framework
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
