using Auto.Test.Framework;
using NUnit.Framework;

namespace B2BMage.Test.Pages
{
    public class ProductPageAssert: BasePageAssert<ProductPageElements>
    {
        public void ValidateAddToCart(string expectedResult)
        {
            Assert.AreEqual(expectedResult, Elements.AddToCartMessage);
        }
    }
}