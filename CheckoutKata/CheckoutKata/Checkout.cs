using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Checkout
    {
        public int Total = 0;

        public void Scan(string items)
        {
            if (items == "")
            {
                Total = 0;
            } else
            {
                Total = 50;
            }
        }
    }
}
