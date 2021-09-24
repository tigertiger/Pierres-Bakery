using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BakeBread_CreateSingleBread_NewBread()
    {
      //Arrange
      string fakeBread = "fakebread";

      //Act
      Bread testBread = new Bread(5);

      //Assert
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

  }
}