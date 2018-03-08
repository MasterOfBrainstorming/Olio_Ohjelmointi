using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Balls
    {
        public int Amount { get; set; }

        public Balls(int amount)
        {
            Amount = amount;
        }

        public override string ToString()
        {
            return "Balls: " + Amount;
        }
    }
}
