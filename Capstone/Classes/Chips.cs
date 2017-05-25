using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Chips: VendableItem
    {
        protected override string Consume()
        {
            return "Crunch, Crunch, YUM!";
        }
        public Chips(decimal price, string name)
        {
            base.price = price;
            base.name = name;
        }
    }
}
