using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Checkout.Tests
{
    [TestClass]
    public class CheckoutTests
    {
        [TestMethod]
        public void Checkout_ScanningNoItems_GivesZero()
        {
            Checkout c = new Checkout();
            c.Scan("");
            Assert.AreEqual(0, c.getTotal());
        }

        [TestMethod]
        public void Checkout_ScanningOneItem_GivesCorrectPrice()
        {
            Checkout c = new Checkout();
            c.Scan("A");
            Assert.AreEqual(50, c.getTotal());
        }
    }
}
