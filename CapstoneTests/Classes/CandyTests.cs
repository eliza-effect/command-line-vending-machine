using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class CandyTests
    {
        [TestMethod]
        public void CandyTest_Constructor()
        {
            decimal price = 1.00M;
            string item = "Candy";

            Candy testItem = new Candy(price, item);
            Assert.AreEqual(item, testItem.Name);
            Assert.AreEqual(price, testItem.Price);
        }

        [TestMethod]
        public void CandyTest_Consume()
        {
            decimal price = 1.00M;
            string item = "Candy";

            Candy testItem = new Candy(price, item);
            Assert.AreEqual("Munch, Munch, YUM!", testItem.Consume());
        }

    }
}
