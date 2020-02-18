using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Scanner
    {
        private Dictionary<char, int> pricingRules;
        private int total;

        public Scanner(Dictionary<char, int> _pricingRules, ref int total)
        {
            pricingRules = _pricingRules;
        }

        public void Scan(char item)
        {
            total = pricingRules[item];
        }

        public void Scan(string items)
        {
            if (items == "")
            {
                total = 0;
            }
            else
            {
                foreach (char item in items)
                {
                    total += pricingRules[item];
                }
            }

        }
    }
}
