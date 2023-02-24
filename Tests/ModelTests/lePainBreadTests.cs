using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;

namespace Boulangerie.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_MakesInstanceOf_()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_ReturnsNumberOfBreadsWanted_()
    {
      Bread newBread = new Bread(1);
      int test = 1;
      Assert.AreEqual(test, newBread.OrderQuantity);
    }

  }
}

