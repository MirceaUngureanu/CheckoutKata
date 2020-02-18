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
            c.ScanItems("");
            Assert.AreEqual(0, c.getTotal());
        }

        [TestMethod]
        [DataRow('A', 50)]
        [DataRow('B', 30)]
        [DataRow('C', 20)]
        [DataRow('D', 10)]
        public void Checkout_ScanningOneItem_GivesCorrectPrice(char item, int expected)
        {
            Checkout c = new Checkout();
            c.ScanItem(item);
            Assert.AreEqual(expected, c.getTotal());
        }

        [TestMethod]
        [DataRow("AA", 100)]
        [DataRow("AAA", 150)]
        public void Checkout_ScanningMultipleOfSameItem_GivesCorrectPrice(string items, int expected)
        {
            Checkout c = new Checkout();
            c.ScanItems(items);
            Assert.AreEqual(expected, c.getTotal());
        }

        [TestMethod]
        [DataRow("AB", 80)]
        [DataRow("ABCD", 110)]
        public void Checkout_ScanningMultipleOfDifferentItem_GivesCorrectPrice(string items, int expected)
        {
            Checkout c = new Checkout();
            c.ScanItems(items);
            Assert.AreEqual(expected, c.getTotal());
        }
    }
}
