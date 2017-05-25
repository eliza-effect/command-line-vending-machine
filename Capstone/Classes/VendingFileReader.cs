﻿using System;
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
        Dictionary<string, Type> classifications = new Dictionary<string, Type>
        {
            {"A", typeof(Chips) },
            {"B", typeof(Candy) },
            {"C", typeof(Beverage) },
            {"D", typeof(Gum) }
        };
        public Dictionary<string, List<VendableItem>> StockMachine()
        {
            List<VendableItem> itemsList = new List<VendableItem>();
            Dictionary<string, List<VendableItem>> inventory = new Dictionary<string, List<VendableItem>>();

            string directory = Directory.GetCurrentDirectory();
            string filename = "vendingmachine.csv";
            string path = Path.Combine(directory, filename);

            try
            {
                using (StreamReader str = new StreamReader(path))
                {
                    while (!str.EndOfStream)
                    {
                        //for (int i = 0; i < 4; i++)
                        //{
                        string line = str.ReadLine();
                        string[] arrayOfPieces = line.Split('|');

                        for (int j = 0; j < 5; j++)
                        {
                            string slotID = arrayOfPieces[0];
                            Type productType = classifications[slotID.Substring(0, 1)];
                            VendableItem item = (VendableItem)Activator.CreateInstance(productType, decimal.Parse(arrayOfPieces[2]), arrayOfPieces[1]);
                            itemsList.Add(item);
                        }
                        inventory.Add(arrayOfPieces[0], itemsList);
                        //}
                        //for (int i = 0; i < 4; i++)
                        //{

                        //    string line = str.ReadLine();
                        //    string[] arrayOfPieces = line.Split('|');

                        //    for (int j = 0; j < 5; j++)
                        //    {
                        //        itemsList.Add(new Candy(decimal.Parse(arrayOfPieces[2]), arrayOfPieces[1]));
                        //    }
                        //    inventory.Add(arrayOfPieces[0], itemsList);
                        //}
                        //for (int i = 0; i < 4; i++)
                        //{
                        //    string line = str.ReadLine();
                        //    string[] arrayOfPieces = line.Split('|');

                        //    for (int j = 0; j < 5; j++)
                        //    {
                        //        itemsList.Add(new Beverage(decimal.Parse(arrayOfPieces[2]), arrayOfPieces[1]));
                        //    }
                        //    inventory.Add(arrayOfPieces[0], itemsList);
                        //}
                        //for (int i = 0; i < 4; i++)
                        //{
                        //    string line = str.ReadLine();
                        //    string[] arrayOfPieces = line.Split('|');

                        //    for (int j = 0; j < 5; j++)
                        //    {
                        //        itemsList.Add(new Gum(decimal.Parse(arrayOfPieces[2]), arrayOfPieces[1]));
                        //    }
                        //    inventory.Add(arrayOfPieces[0], itemsList); 
                        //}
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
