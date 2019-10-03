using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppigCartLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppigCartLib.Tests
{
    [TestClass()]
    public class ShoppigCartTests
    {
        private ShoppigCart cart;
        private Item item;

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("TestInitialize");
            item = new Item("TestName", 10);

            cart = new ShoppigCart();
            cart.Add(item);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("TestCleanup");
            cart.Dispose();
        }

        [TestMethod()]
        public void Cart_Check_ContainsItem()
        {
            CollectionAssert.Contains(cart.Items, item);
        }

        [TestMethod()]
        public void Cart_Remove_Empty()
        {
            cart.Remove(0);
            Assert.AreEqual(0, cart.Count);
        }
    }
}