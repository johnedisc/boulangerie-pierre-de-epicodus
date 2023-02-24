using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boulangerie.Models;

namespace LePainBread.Tests
{
  [TestClass]
  public class LePainBreadTests
  {
    [TestMethod]
    public void LePainBreadConstructor_MakesInstanceOfLePain_LePain()
    {
      LePainBread newLePain = new LePainBread();
      Assert.AreEqual(typeof(LePainBread), newLePain.GetType());
    }
  }
}

