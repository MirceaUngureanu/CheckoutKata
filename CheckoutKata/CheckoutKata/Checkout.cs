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
        private Dictionary<string, int> pricingRules = new Dictionary<string, int>()
        {
            { "A", 50 },
            { "B", 30 }
        };

        public int getTotal()
        {
            return total;
        }

        public void Scan(string item)
        {
            if (item == "")
            {
                total = 0;
            } else
            {
                total = pricingRules[item];
            }
        }
    }
}
