using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class ChangeMaker
    {
        private int numQuarters = 0;
        public int NumQuarters
        {
            get { return this.numQuarters; }
        }

        private int numDimes;
        public int NumDimes
        {
            get { return this.numDimes; }
        }

        private int numNickels;
        public int NumNickels
        {
            get { return this.numNickels; }
        }
        private decimal balance;
      

        public ChangeMaker(decimal balance)
        {
            this.balance = balance;
        }

        public List<int> MakeChange()
        {
            List<int> coinCount = new List<int>();

            Console.WriteLine("Your change is: $" + balance);
            while (balance > 0)
            {
               int temp = (int) (balance * 100);
                numQuarters = (int)temp / 25;
                temp = temp % 25;
                numDimes = (int)temp / 10;
                temp = temp % 10;
                numNickels = (int)temp / 5;
                temp = temp % 5;
                balance = (int) temp;

                if (temp > 0)
                {
                    Console.WriteLine("ChangeMaker is broken");
                    break;
                }
                    

               //// if (temp % 25 == 0)
               // {
               //     this.numQuarters = numQuarters + 1;
               //     temp -= 25;
               // }
               // else if (temp % 10 == 0)
               // {
               //     numDimes++;
               //     temp -= 10;
               // }
               // else if (temp % 5 == 0)
               // {
               //     numNickels++;
               //     temp -= 5;
               // }
            }
            coinCount.AddRange(new List<int>{numQuarters, numDimes, numNickels});
            Console.WriteLine("Dispensing...");
            Console.WriteLine(numQuarters + " Quarters");
            Console.WriteLine(numDimes + " Dimes");
            Console.WriteLine(numNickels + " Nickels");
            Console.WriteLine("Enjoy your selection");
            return coinCount;
          

        }

    }
}
