using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        private Dictionary<string, List<VendableItem>> items = new VendingFileReader().StockMachine();
        private bool isSoldOut;

        public Dictionary<string, List<VendableItem>> Items
        {
            get { return this.items; }
        }





        public void PurchaseMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Make Purchase");
                Console.WriteLine("1] >> Feed Money");
                Console.WriteLine("2] >> Select Product");
                Console.WriteLine("3] >> Finish Transaction");
                Console.WriteLine("Q] >> Return to Main Menu");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Feed Money");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Select Product");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Finish Transaction");
                }
                else if (input == "Q")
                {
                    Console.WriteLine("Returning to main menu");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

            }

        }
    }
}
