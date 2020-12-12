using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class TestBread
    {
        [TestMethod]
        public void BreadConstructor_InstanceOfBread_True()
        {
            Bread quantity = new Bread(5);
            Assert.AreEqual(typeof(Bread), quantity.GetType());
        }
            [TestMethod]
            public void BreadTotal_ReturnCostOfBread_Int()
        {
            Bread newOrder = new Bread(5);
            Assert.AreEqual(20, newOrder.BreadTotal());
        }
    } 
}