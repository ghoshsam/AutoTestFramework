using Auto.Test.Framework.PageObject;
using Auto.Test.Framework;
using OpenQA.Selenium;

namespace B2BMage.Test.Pages
{
    public class ProductPageElements: BasePageElements
    {
        public IWebElement PageTitle
        {
            get => WebDriver.FindElement(By.XPath(@"//div[@class='page-title-wrapper product']/h1[@class='page-title']/span[@class='base']"));
        }

        public IWebElement SelectColor
        {
            get => WebDriver.FindElement(By.XPath(@"//div[@class='swatch-opt']/div[@class='swatch-attribute color']/div[@class='swatch-attribute-options clearfix']/div[@class='swatch-option color'][1]"));
        }
        public IWebElement SelectSize
        {
            get => WebDriver.FindElement(By.XPath(@"//div[@class='swatch-attribute size']/div[@class='swatch-attribute-options clearfix']/div[@class='swatch-option text'][1]"));
        }
        public IWebElement Qty
        {
            get => WebDriver.FindElement(By.Id("qty"));
        }
        public IWebElement AddToCart
        {
            get => WebDriver.FindElement(By.Id("product-addtocart-button"));
        }

        public IWebElement AddToCartMessage
        {
            get => WebDriver.FindElement(ByAttribute.Attribute("data-bind", "html: message.text"));
        }
    }
}