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
            Assert.Equals(0, c.Total);
        }
    }
}
