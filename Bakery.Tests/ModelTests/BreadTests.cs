using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }

    [TestMethod]
    public void Bread_CreateSingleBread_NewBread()
    {
      //Arrange
      // string fakeBread = "fakebread";

      //Act
      Bread testBread = new Bread(5);

      //Assert
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void Bread_ReturnBreadPrice_Price()
    {
      //Arrange
      int price = 5;
      Bread testBread = new Bread(price);

      //Act
      int basePrice = testBread.Price;

      //Assert
      Assert.AreEqual(price, basePrice);
    }

    [TestMethod]
    public void GetAll_ReturnEmptyList_BreadList()
    {
      //Arrange
      List<Bread> testOrder = new List<Bread> {};
      
      //Act
      List<Bread> glorbus = Bread.GetAll();

      //Assert
      CollectionAssert.AreEqual(testOrder, glorbus);
    }
  }
}

      //Arrange
      //Act
      //Assert