using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using eCommerceApp.Model;

namespace eCommerceApp.UnitTest
{
    [TestClass]
    public class PricingCalculationTest
    {
        private eCommerceApp.Model.ShoppingCart _cart;

        [TestInitialize]
        public void Setup()
        {
            _cart = new Model.ShoppingCart();
        }

        [TestMethod]
        public void TwoItemsSelectedWithBuy2Get1FreeDiscountCoupon()
        {
            _cart.Add(new OrderItem() { Quantity = 2, Sku = "B2G1_TOYS" });
            Assert.AreEqual(2m, _cart.TotalAmount());
        }

        [TestMethod]
        public void ThreeItemSelectedWithBuy4Get1FreeDiscountCoupon()
        {
            _cart.Add(new OrderItem() { Quantity = 3, Sku = "B2G1_TOYS" });
            Assert.AreEqual(2m, _cart.TotalAmount());
        }
    }
}
