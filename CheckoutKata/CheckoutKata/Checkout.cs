using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Checkout
    {
        private int total = 0;
        private int discountQuantity;
        private int discountTotal;
        private Dictionary<char, int> pricingRules = new Dictionary<char, int>()
        {
            { 'A', 50 },
            { 'B', 30 },
            { 'C', 20 },
            { 'D', 10 }
        };
        public Scanner scanner;

        public Checkout()
        {
            scanner = new Scanner(pricingRules);
        }

        public int GetTotal()
        {
            // check discount rules
            // check scanned items (store a string)
            // see which discount rules apply
            // sum up discount
            // total - discount
            return total;
        }

        public void ScanItem(char item)
        {
            total = scanner.ScanItem(item);
        }

        public void ScanItems(string items)
        {
            if (items == "")
            {
                total = 0;
            }
            else
            {
                foreach (char item in items)
                {
                    total += scanner.ScanItem(item);
                }
            }
        }

        public void ApplyDiscountRules(int quantity, int total)
        {
            discountQuantity = quantity;
            discountTotal = total;
        }

    }
}
