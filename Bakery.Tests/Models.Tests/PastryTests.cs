using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class TestPastry
  {
    [TestMethod]
    public void PastryConstructor_InstanceOfPastry_True()
    {
    Pastry purchase = new Pastry(2);
    Assert.AreEqual(typeof(Pastry), purchase.GetType());
    }

    [TestMethod]
    public void PastryConstructor_AcceptsAmount_Int()
    {
    Pastry purchase = new Pastry(2);
    Assert.AreEqual(true, purchase.AmountOfPastry());
    }
  }
}