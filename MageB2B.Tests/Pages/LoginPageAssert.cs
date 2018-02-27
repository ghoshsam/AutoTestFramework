using Auto.Test.Framework.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2BMage.Test.Pages
{
    public class LoginPageAssert:BasePageAssert<LoginPageElements>
    {
        public void Validate(string expectedResult)
        {
            Assert.AreEqual(expectedResult, Elements.ResultValue.Text);
        }
    }
}
