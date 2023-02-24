using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;
using System.Collections.Generic;
using System;

namespace Boulangerie.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_MakesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_ReturnsNumberOfPastrysWanted_Int()
    {
      Pastry newPastry = new Pastry(1);
      int test = 1;
      Assert.AreEqual(test, newPastry.OrderQuantity);
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsPastryCostWithDiscount_Int()
    {
      Pastry newPastry = new Pastry(6);
      int expectedResult = 10;
      Assert.AreEqual(expectedResult, newPastry.CalculatePastryCost());
    }

  }
}

