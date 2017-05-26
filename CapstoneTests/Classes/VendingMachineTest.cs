using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;
using System.Collections.Generic;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void Buys3Items()
        {
            VendingMachine testMachine = new VendingMachine();
            testMachine.FeedMoney(20m);
            testMachine.Purchase("A1");
            testMachine.Purchase("A1");
            testMachine.Purchase("A1");
            Assert.AreEqual(2, testMachine.Items["A1"].Count);
        }

        [TestMethod]
        public void Buys4Items()
        {
            VendingMachine testMachine = new VendingMachine();
            testMachine.FeedMoney(20m);
            testMachine.Purchase("A1");
            testMachine.Purchase("A1");
            testMachine.Purchase("A1");
            testMachine.Purchase("A1");
            Assert.AreEqual(1, testMachine.Items["A1"].Count);
        }

        [TestMethod]
        public void Buys5Items()
        {
            VendingMachine testMachine = new VendingMachine();
            testMachine.FeedMoney(20m);
            testMachine.Purchase("A1");
            testMachine.Purchase("A1");
            testMachine.Purchase("A1");
            testMachine.Purchase("A1");
            testMachine.Purchase("A1");
            Assert.AreEqual(0, testMachine.Items["A1"].Count);
        }

    }
}
