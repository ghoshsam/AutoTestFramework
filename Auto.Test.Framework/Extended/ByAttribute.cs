using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


    public class ByAttribute
{
        public static By Attribute(string attribute,string value)
        {
            return By.XPath($"//*[@{attribute}='{value}']");
        }
    }
