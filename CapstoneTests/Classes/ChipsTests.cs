using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;


namespace CapstoneTests.Classes
{
    [TestClass]
    public class ChipsTests
    {
        [TestMethod]
        public void ChipsTest_Constructor()
        {
            decimal price = 1.00M;
            string item = "Chips";

            Chips testItem = new Chips (price, item);
            Assert.AreEqual(item, testItem.Name);
            Assert.AreEqual(price, testItem.Price);
        }

        [TestMethod]
        public void ChipsTest_Consume()
        {
            decimal price = 1.00M;
            string item = "Chips";

            Chips testItem = new Chips (price, item);
            Assert.AreEqual("Crunch, Crunch, YUM!", testItem.Consume());
        }
    }
}
