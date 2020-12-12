using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class TestPastry
    {
        [TestMethod]
        public void PastryConstructor_InstanceOfPastry_True()
        {
            Pastry quantity = new Pastry(2);
            Assert.AreEqual(typeof(Pastry), quantity.GetType());
        }
            [TestMethod]
            public void PastryConstructor_AcceptsAmount_Int()
        {
            Pastry quantity = new Pastry(2);
            Assert.AreEqual(true, quantity.AmountOfPastry());
        }
            [TestMethod]
            public void PastryPrice_AssignCostToPastry_Int()
        {
            Pastry quantity = new Pastry(2);
            Dictionary<string, int> value = new Dictionary<string, int> 
            {
            {"Pastry", 2}
            };
            CollectionAssert.AreEqual(value, quantity.PastryPrice());
        }
            [TestMethod]
            public void PastryTotal_ReturnCostOfPastry_Int()
        {
            Pastry newOrder = new Pastry(2);
            Assert.AreEqual(4, newOrder.PastryTotal());
        }
    }
}