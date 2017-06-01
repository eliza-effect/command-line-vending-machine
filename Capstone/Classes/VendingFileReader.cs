using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Capstone.Classes
{
    public class VendingFileReader
    {
        //Dictionary<string, Type> classifications = new Dictionary<string, Type>
        //{
        //    {"A", typeof(Chips) },
        //    {"B", typeof(Candy) },
        //    {"C", typeof(Beverage) },
        //    {"D", typeof(Gum) }
        //};
        public Dictionary<string, List<VendableItem>> StockMachine()
        {
            Dictionary<string, List<VendableItem>> inventory = new Dictionary<string, List<VendableItem>>();

            string directory = Directory.GetCurrentDirectory();
            string filename = "vendingmachine.csv";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamReader str = new StreamReader(fullPath))
                {
                    while (!str.EndOfStream)
                    {
                        List<VendableItem> itemsList = new List<VendableItem>();
                        string line = str.ReadLine();
                        string[] parts = line.Split('|');
                        const int SlotIndex = 0;
                        const int ProductIndex = 1;
                        const int PriceIndex = 2;

                        if (parts[SlotIndex].StartsWith("A"))
                        {
                            for(int i = 0; i < 5; i++)
                            {
                                itemsList.Add(new Chips(decimal.Parse(parts[PriceIndex]), parts[ProductIndex]));
                            }
                            inventory.Add(parts[SlotIndex], itemsList);
                        }
                        else if (parts[SlotIndex].StartsWith("B"))
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                itemsList.Add(new Candy(decimal.Parse(parts[PriceIndex]), parts[ProductIndex]));
                            }
                            inventory.Add(parts[SlotIndex], itemsList);
                        }
                        else if (parts[SlotIndex].StartsWith("C"))
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                itemsList.Add(new Beverage(decimal.Parse(parts[PriceIndex]), parts[ProductIndex]));
                            }
                            inventory.Add(parts[SlotIndex], itemsList);
                        }
                        else if (parts[SlotIndex].StartsWith("D"))
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                itemsList.Add(new Gum(decimal.Parse(parts[PriceIndex]), parts[ProductIndex]));
                            }
                            inventory.Add(parts[SlotIndex], itemsList);
                        }
                    }
                }
                
                return inventory;

            }
            catch (IOException e)
            {
                Console.WriteLine("Couldn't read file. " + e.Message);
                return inventory;
            }

        }
    }

}
