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
      Bread testBread = new Bread(1, 5);

      //Assert
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void Bread_ReturnBreadPrice_Price()
    {
      //Arrange
      int price = 5;
      Bread testBread = new Bread(1, price);

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
      Bread thirtyThreeLbBread = new Bread(1, spendy);
      Bread sourdoughLoaf = new Bread(1, basePrice);
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

      //Arrange
      int spendy = 33;
      int basePrice = 5;
      Bread thirtyThreeLbBread = new Bread(1, spendy);
      Bread sourdoughLoaf = new Bread(1, basePrice);
      List<Bread> breadOrder = new List<Bread> {thirtyThreeLbBread, sourdoughLoaf};

      //Act
      int countLoaves = breadOrder.Count;
      int testCount = 2;

      //Assert
      Assert.AreEqual(testCount, countLoaves);
    }

    [TestMethod] 
    public void Cashier_CalculateOrderPrice_TotalPrice()
    {
      // Arrange
      int price = 5;
      Bread wholeWheatLump = new Bread(1, price);
      Bread sourdoughLoaf = new Bread(1, price);
      List<Bread> breadOrder = new List<Bread> {wholeWheatLump, sourdoughLoaf};
      int orderPrice = 10;

      //Act
      int testOrderPrice = wholeWheatLump.Cashier();

      //Assert
      Assert.AreEqual(orderPrice, testOrderPrice);

    }

    [TestMethod] 
    public void Cashier_CalculateBigOrderPrice_TotalPrice()
    {
      // Arrange
      int price = 5;
      Bread wholeWheatLump = new Bread(1, price);
      Bread sourdoughLoaf = new Bread(1, price);
      Bread badBaguette = new Bread(1, price);
      Bread notABreadAtAll = new Bread(1, price);
      Bread humanMeatBao = new Bread(1, price);
      List<Bread> breadOrder = new List<Bread> {wholeWheatLump, sourdoughLoaf, badBaguette, notABreadAtAll, humanMeatBao};
      int orderPrice = 20;

      //Act
      int testOrderPrice = wholeWheatLump.Cashier();

      //Assert
      Assert.AreEqual(orderPrice, testOrderPrice);

    }
  }
}