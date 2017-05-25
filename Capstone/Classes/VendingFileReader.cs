using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    public class VendingFileReader
    {
        public Dictionary<string, List<string>> StockMachine()
        {

            Dictionary<string, List<VendableItem>> inventory = new Dictionary<string, List<VendableItem>>();
            List<VendableItem> items = new List<VendableItem>();
            string directory = Directory.GetCurrentDirectory();
            string filename = "vendingmachine.csv";
            string path = Path.Combine(directory, filename);

            try
            {
                using (StreamReader str = new StreamReader(path))
                {
                    while (!str.EndOfStream)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            string line = str.ReadLine();
                            string[] arrayOfPieces = line.Split('|');

                            for (int j = 0; j < 5; j++)
                            {
                                items.Add(new Chips(decimal.Parse(arrayOfPieces[2]), arrayOfPieces[1]));
                            }
                            inventory.Add(arrayOfPieces[0], items);
                        }
                        for (int i = 0; i < 4; i++)
                        {

                            string line = str.ReadLine();
                            string[] arrayOfPieces = line.Split('|');

                            for (int j = 0; j < 5; j++)
                            {
                                items.Add(new Candy(decimal.Parse(arrayOfPieces[2]), arrayOfPieces[1]));
                            }
                            inventory.Add(arrayOfPieces[0], items);
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            string line = str.ReadLine();
                            string[] arrayOfPieces = line.Split('|');

                            for (int j = 0; j < 5; j++)
                            {
                                items.Add(new Beverage(decimal.Parse(arrayOfPieces[2]), arrayOfPieces[1]));
                            }
                            inventory.Add(arrayOfPieces[0], items);
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            string line = str.ReadLine();
                            string[] arrayOfPieces = line.Split('|');

                            for (int j = 0; j < 5; j++)
                            {
                                items.Add(new Gum(decimal.Parse(arrayOfPieces[2]), arrayOfPieces[1]));
                            }
                            inventory.Add(arrayOfPieces[0], items); 
                        }
                    }
                   
                }
                return inventory;
               
            }
            catch(IOException e)
            {
                Console.WriteLine("Couldn't read file. " + e.Message);
                return inventory;
            }
           
        }
}

}
