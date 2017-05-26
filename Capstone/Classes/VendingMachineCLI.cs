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

                    foreach(KeyValuePair<string, List<VendableItem>> kvp in vendor.Items)
                    {
                        string temp = "";
                        
                        if(kvp.Value.Count == 0)
                        {
                            temp = "Sold Out!";        // checks to see whether slot is empty & changes display if yes

                        }
                        else
                        {
                            temp = kvp.Value[0].Name;  // if not empty, display name of product
                        }
                        
                        Console.WriteLine(kvp.Key.PadRight(10) + temp.PadRight(20) + kvp.Value[0].Price.ToString().PadRight(10) + "Quantity: " + kvp.Value.Count);
                    }
                    //if (IsSoldOut(slot))
                    //{
                    //    items[slot][0].Name
                    //}
                }
                else if (input == "2")
                {
                    vendor.PurchaseMenu();
                }
                else if (input.ToLower() == "q")
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

