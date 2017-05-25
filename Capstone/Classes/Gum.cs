using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Gum: VendableItem
    {
        public override string Consume()
        {
            return "Chew, Chew, YUM!";
        }
        public Gum(decimal price, string name)
        {
            base.price = price;
            base.name = name;
        }
    }
}
