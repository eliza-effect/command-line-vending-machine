using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Candy: VendableItem
    {
        protected override string Consume()
        {
            return "Munch, Munch, YUM!";
        }
        public Candy(decimal price, string name)
        {
            base.price = price;
            base.name = name;
        }
    }
}
