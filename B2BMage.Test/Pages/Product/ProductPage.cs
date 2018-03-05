using System;
using System.Collections.Generic;
using System.Text;
using Auto.Test.Framework.BrowserDrivers;
using Auto.Test.Framework.PageObject;

namespace B2BMage.Test.Pages
{
    public class ProductPage: BasePageObject<ProductPageElements, ProductPageAssert>
    {
        public ProductPage(IBrowserDriver browserDriver) : base(browserDriver)
        {

        }
        public override void Navigate(string part = "desiree-fitness-tee.html")
        {
            base.Navigate(part);
        }
    }
}
