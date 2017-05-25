using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public abstract class VendableItem
    {
        protected decimal price;
        public decimal Price
        {
            get { return this.price; }
        }
        protected string name;
        public string Name
        {
            get { return this.name; }
        }
        protected abstract string Consume();
        //protected abstract decimal Cost();
        //protected abstract string Name();

        
    }
}
