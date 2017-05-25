using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachineCLI
    {
        public void DisplayMenu()
        {
            VendingMachine vendor = new VendingMachine();
            Dictionary<string,  List<VendableItem> > test = new Dictionary<string, List<VendableItem>>();

            PrintHeader();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1] >> Display Vending Machine Items");
                Console.WriteLine("2] >> Purchase");
                Console.WriteLine("Q] >> Quit");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Displaying items: ");
                    //loop through entire list to display contents
                    foreach(KeyValuePair<string, List<VendableItem>> kvp in vendor.Items)
                    {
                        Console.WriteLine(kvp.Key + "   " + kvp.Value[0].Name + "   " + kvp.Value[0].Price + "   Quantity: " + kvp.Value.Count);
                    }

                }
                else if (input == "2")
                {
                    VendingMachine vend = new VendingMachine();
                    vend.PurchaseMenu();
                }
                else if (input == "Q")
                {
                    Console.WriteLine("Come again!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again...");
                }
            }
        }

        private void PrintHeader()
        {

            Console.WriteLine("WELCOME!!!!");
        }
    }

}

