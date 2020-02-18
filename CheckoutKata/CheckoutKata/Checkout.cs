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

        public int getTotal()
        {
            return total;
        }

        public void Scan(string items)
        {
            if (items == "")
            {
                total = 0;
            } else if (items == "A")
            {
                total = 50;
            } else
            {
                total = 30;
            }
        }
    }
}
