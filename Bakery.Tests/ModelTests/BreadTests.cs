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

    [TestMethod]
    public void BakeBread_ReturnBreadPrice_Price()
    {
      //Arrange
      int price = 5;

      //Act
      Bread testBread = new Bread(price);
      int basePrice = testBread.Price;

      //Assert
      Assert.AreEqual(price, basePrice);
    }
  }
}

      //Arrange
      //Act
      //Assert