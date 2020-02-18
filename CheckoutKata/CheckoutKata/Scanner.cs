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

        public Scanner(Dictionary<char, int> _pricingRules)
        {
            pricingRules = _pricingRules;
        }

        public int ScanItem(char item)
        {
            return pricingRules[item];
        }
    }
}
