﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Checkout
    {
        private int total = 0;
        private Dictionary<char, int> pricingRules = new Dictionary<char, int>()
        {
            { 'A', 50 },
            { 'B', 30 },
            { 'C', 20 },
            { 'D', 10 }
        };

        public int getTotal()
        {
            return total;
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
                foreach(char item in items)
                {
                    total += pricingRules[item];
                }
            }

        }
    }
}
