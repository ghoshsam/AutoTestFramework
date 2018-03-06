using Auto.Test.Framework;
using B2BMage.Test.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2BMage.Test.Behaviours
{
    public class ProductNavigationBehaviour : ActionBehaviour
    {
        private readonly ProductPage _productPage;
        private readonly string _productUrl;
        public ProductNavigationBehaviour(ProductPage productPage,string productUrl) {
            _productPage = productPage;
            _productUrl = productUrl;
        }
        protected override void PerformAct()
        {
            if (!String.IsNullOrEmpty(_productUrl))
                _productPage.Navigate(_productUrl);
            else
                _productPage.Navigate();
        }
    }
}
