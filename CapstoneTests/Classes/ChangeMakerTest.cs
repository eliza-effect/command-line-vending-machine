using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;
using System.Collections.Generic;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class ChangeMakerTest
    {
        [TestMethod]
        public void ChangeMakerTwo15()
        {
            ChangeMaker testAcct = new ChangeMaker(2.15m);
            List<int> changeDue = new List<int>() { 8, 1, 1 };
            CollectionAssert.AreEqual(changeDue, testAcct.MakeChange());
        }

        [TestMethod]
        public void ChangeMakeCoins215()
        {
            ChangeMaker testAcct = new ChangeMaker(2.15m);
            Assert.AreEqual(8, testAcct.MakeChange()[0]);
            Assert.AreEqual(1, testAcct.MakeChange()[1]);
            Assert.AreEqual(1, testAcct.MakeChange()[2]);
        }
    }
}
