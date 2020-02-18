using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class Scanner
    {
        private Dictionary<char, int> pricingRules;

        public Scanner(Dictionary<char, int> _pricingRules)
        {
            pricingRules = _pricingRules;
        }
    }
}
