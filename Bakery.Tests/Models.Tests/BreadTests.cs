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
    Bread purchase = new Bread(5);
    Assert.AreEqual(typeof(Bread), purchase.GetType());
    }
    [TestMethod]
    public void BreadConstructor_AcceptsAmount_Int()
    {
    Bread purchase = new Bread(5);
    Assert.AreEqual(true, purchase.AmountOfBread());
    }
    [TestMethod]
    public void BreadPrice_AssignPriceToBread_Int()
    {
      Bread purchase = new Bread(5);
      Dictionary<string, int> value = new Dictionary<string, int> 
      {
        {"Bread", 5}
      };
      CollectionAssert.AreEqual(value, purchase.BreadPrice());
    }
    [TestMethod]
    public void BreadCost_ReturnCostOfBread_Int()
    {
      Bread newOrder = new Bread(5);
      Dictionary<string, int> value = new Dictionary<string, int>
      {
        {"Bread", 5}
      };
      Assert.AreEqual(25, newOrder.BreadPrice(value));
    }
  } 
}