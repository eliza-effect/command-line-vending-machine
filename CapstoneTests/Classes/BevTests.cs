using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;


namespace CapstoneTests.Classes
{
    [TestClass]
    public class BeverageTest
    {
        [TestMethod]
        public void BeverageTest_Constructor()
        {
            decimal price = 1.00M;
            string item = "drink";
            Beverage testItem = new Beverage(price, item);
            Assert.AreEqual("drink", testItem.Name);

        }
        [TestMethod]
        public void BeverageTest_Consume()
        {
            decimal price = 1.00M;
            string item = "drink";
            Beverage testItem = new Beverage(price, item);
            Assert.AreEqual("Glug, Glug, YUM!", testItem.Consume());

        }
    }

}
