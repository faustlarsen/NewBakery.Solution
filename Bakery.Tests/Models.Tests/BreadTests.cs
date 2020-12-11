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
    Bread purchase = new Bread(2);
    Assert.AreEqual(typeof(Bread), purchase.GetType());
    }

    [TestMethod]
    public void BreadConstructor_AcceptsAmount_Int()
    {
    Bread purchase = new Bread(2);
    Assert.AreEqual(true, purchase.AmountOfBread(2));
    }

    [TestMethod]
    public void BreadPrice_AssignPriceToBread_Int()
    {
      Bread purchase = new Bread(3);
      Dictionary<string, int> value = new Dictionary<string, int> 
      {
        {"Bread", 2}
      };
      CollectionAssert.AreEqual(value, purchase.BreadPrice());
    }
  } 
}