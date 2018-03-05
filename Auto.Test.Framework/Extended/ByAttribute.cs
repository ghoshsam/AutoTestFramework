using OpenQA.Selenium;


public class ByAttribute
{
        public static By Attribute(string attribute,string value)
        {
            return By.XPath($"//*[@{attribute}='{value}']");
        }
    }
