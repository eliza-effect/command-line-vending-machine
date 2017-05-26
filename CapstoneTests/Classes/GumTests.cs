using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;


namespace CapstoneTests.Classes
{
    [TestClass]
    public class GumTests
    {
        [TestMethod]
        public void GumTest_Constructor()
        {
            decimal price = 1.00M;
            string item = "Gum";

            Gum testItem = new Gum(price, item);
            Assert.AreEqual(item, testItem.Name);
            Assert.AreEqual(price, testItem.Price);
        }

        [TestMethod]
        public void GumTest_Consume()
        {
            decimal price = 1.00M;
            string item = "Gum";

            Gum testItem = new Gum(price, item);
            Assert.AreEqual("Chew, Chew, YUM!", testItem.Consume());
        }
    }
}
