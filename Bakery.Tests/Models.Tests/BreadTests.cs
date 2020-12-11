using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public void BreadConstructor_ExceptsAmount_Int()
    {
    Bread purchase = new Bread(2);
    Assert.AreEqual(true, purchase.AmountOfBread(2));
    }
  }
} 