﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        private Dictionary<string, List<VendableItem>> items = new VendingFileReader().StockMachine();
        private List<VendableItem> purchasedItems = new List<VendableItem>();
        private bool isSoldOut;
        private decimal balance = (decimal)0.00;

        public Dictionary<string, List<VendableItem>> Items
        {
            get { return this.items; }
        }

        public decimal Balances
        {
            get { return this.balance; }
        }

        public bool IsSoldOut(string slot)
        {
            return items[slot].Count == 0;
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

                Console.WriteLine($"\nCurrent money provided: {this.balance}");

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine().ToLower();

                if (input == "1")
                {
                    Console.WriteLine("Feed Money");
                    Console.WriteLine("How much money are you putting in?");
                    decimal amt = decimal.Parse(Console.ReadLine());
                    decimal[] validBills = { 1, 2, 5, 10, 20 };
                    if (!validBills.Contains(amt))
                    {
                        Console.WriteLine("Please enter a valid dollar bill!");
                        break;
                    }
                    this.FeedMoney(amt);
                }
                else if (input == "2")
                {
                    Console.WriteLine("Select Product");
                    Console.WriteLine("Which slot are you choosing from?");
                    string slot = Console.ReadLine().ToUpper();
                    this.Purchase(slot);

                }
                else if (input == "3")
                {
                    Console.WriteLine("Finishing Transaction");
                    this.CompleteTransaction();
                }
                else if (input == "q")
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

        public void FeedMoney(decimal dollars)
        {
            VendingFileWriter vfw = new VendingFileWriter();
            vfw.WriteToLog("FEED MONEY:   $" + balance + "  $" + (balance + dollars));
            this.balance += dollars;
        }

        public VendableItem Purchase(string slot)
        {
            if (!IsSoldOut(slot))
            {
                if (items[slot][0].Price <= this.balance)
                {
                    VendableItem selection = items[slot][0];
                    VendingFileWriter vfw = new VendingFileWriter();
                    vfw.WriteToLog($"{items[slot][0].Name}  {slot}   $" + balance + "  $" + (balance - items[slot][0].Price));
                    balance -= items[slot][0].Price;
                    purchasedItems.Add(items[slot][0]);
                    items[slot].Remove(items[slot][0]);
                   
                    return selection;
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Please insert more money!");
                    return null;   // return nothing because not enough money!
                }
            }
            else
            {
                Console.WriteLine("Item is sold out. Please select something else.");
                return null;    //return nothing because it is sold out
            }
        }

        public void CompleteTransaction() //placeholder
        {
            ChangeMaker c = new ChangeMaker(this.balance);
            c.MakeChange();
            VendingFileWriter vfw = new VendingFileWriter();
            vfw.WriteToLog("Give Change:   " + balance + "  " + ("$0.00"));
            this.balance = 0;
            foreach(VendableItem e in purchasedItems)
            {
                Console.WriteLine(e.Consume());
            }
            purchasedItems.Clear();
            
        }

    }
}
