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
    public void GetYourBreads_ReturnEmptyList_BreadList()
    {
      //Arrange
      List<Bread> testOrder = new List<Bread> {};
      
      //Act
      List<Bread> glorbus = Bread.GetYourBreads();

      //Assert
      CollectionAssert.AreEqual(testOrder, glorbus);
    }

    [TestMethod]
    public void GetYourBreads_ReturnBreads_BreadList()
    {
      //Arrange
      int spendy = 33;
      int basePrice = 5;
      Bread thirtyThreeLbBread = new Bread(spendy);
      Bread sourdoughLoaf = new Bread(basePrice);
      List<Bread> breadOrder = new List<Bread> {thirtyThreeLbBread, sourdoughLoaf};
      List<Bread> halfOrder = new List<Bread> {sourdoughLoaf};

      //Act
      List<Bread> checkOrder = Bread.GetYourBreads();

      //Assert
      CollectionAssert.AreEqual(breadOrder, checkOrder);
    }

    [TestMethod]
    public void Bread_CalculateLoaves_BreadNumber()
    {
      int spendy = 33;
      int basePrice = 5;
      Bread thirtyThreeLbBread = new Bread(spendy);
      Bread sourdoughLoaf = new Bread(basePrice);
      List<Bread> breadOrder = new List<Bread> {thirtyThreeLbBread, sourdoughLoaf};

      //Arrange
      int price = 5;
      int loaves = 2;
      Bread testBread = new Bread(price);

      //Act
      int baseLoaves = testBread.Loaves;

      //Assert
      Assert.AreEqual(loaves, baseLoaves);
    }
  }
}

      //Arrange
      //Act
      //Assert