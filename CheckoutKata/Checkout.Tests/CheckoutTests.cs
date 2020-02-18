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
        [DataRow("A", 50)]
        [DataRow("B", 30)]
        public void Checkout_ScanningOneItem_GivesCorrectPrice(string items, int expected)
        {
            Checkout c = new Checkout();
            c.Scan(items);
            Assert.AreEqual(expected, c.getTotal());
        }
    }
}
