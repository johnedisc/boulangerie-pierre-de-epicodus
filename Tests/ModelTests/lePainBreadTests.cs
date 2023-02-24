using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_MakesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_ReturnsNumberOfBreadsWanted_Int()
    {
      Bread newBread = new Bread(1);
      int test = 1;
      Assert.AreEqual(test, newBread.OrderQuantity);
    }

    [TestMethod]
    public void CalculateBreadCost_ReturnsBreadCostWithDiscount_Int()
    {
      Bread newBread = new Bread(7);
      int expectedResult = 25;
      Assert.AreEqual(expectedResult, newBread.CalculateBreadCost());
    }

  }
}

