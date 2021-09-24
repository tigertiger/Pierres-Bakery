using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void Pastry_CreateSinglePastry_NewPastry()
    {
      //Arrange
      // string fakePastry = "fakepastry";

      //Act
      Pastry testPastry = new Pastry(1, 2);

      //Assert
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }

    [TestMethod]
    public void Pastry_ReturnPastryPrice_Price()
    {
      //Arrange
      int price = 2;
      Pastry testPastry = new Pastry(1, price);

      //Act
      int basePrice = testPastry.Price;

      //Assert
      Assert.AreEqual(price, basePrice);
    }

    [TestMethod]
    public void GetYourPastries_ReturnEmptyList_PastryList()
    {
      //Arrange
      List<Pastry> testOrder = new List<Pastry> {};
      
      //Act
      List<Pastry> nullOrder = Pastry.GetYourPastries();

      //Assert
      CollectionAssert.AreEqual(testOrder, nullOrder);
    }

    [TestMethod]
    public void GetYourPastries_ReturnPastries_PastryList()
    {
      //Arrange
      int spendy = 33;
      int basePrice = 5;
      Pastry cutieCupcake = new Pastry(1, spendy);
      Pastry baklava = new Pastry(1, basePrice);
      List<Pastry> PastryOrder = new List<Pastry> {cutieCupcake, baklava};

      //Act
      List<Pastry> checkOrder = Pastry.GetYourPastries();

      //Assert
      CollectionAssert.AreEqual(PastryOrder, checkOrder);
    }

    [TestMethod]
    public void Pastry_CalculateCrubs_PastryNumber()
    {

      //Arrange
      int spendy = 33;
      int basePrice = 5;
      Pastry cutieCupcake = new Pastry(1, spendy);
      Pastry baklava = new Pastry(1, basePrice);
      List<Pastry> PastryOrder = new List<Pastry> {cutieCupcake, baklava};

      //Act
      int countCrubs = PastryOrder.Count;
      int testCount = 2;

      //Assert
      Assert.AreEqual(testCount, countCrubs);
    }

    [TestMethod] 
    public void Cashier_CalculateOrderPrice_TotalPrice()
    {
      // Arrange
      int price = 2;
      Pastry staleCrust = new Pastry(1, price);
      Pastry cutieCupcake = new Pastry(1, price);
      List<Pastry> PastryOrder = new List<Pastry> {staleCrust, cutieCupcake};
      int orderPrice = 4;

      //Act
      int testOrderPrice = staleCrust.Cashier();

      //Assert
      Assert.AreEqual(orderPrice, testOrderPrice);

    }

    [TestMethod] 
    public void Cashier_CalculateBigOrderPrice_TotalPrice()
    {
      // Arrange
      int price = 2;
      Pastry staleCrust = new Pastry(1, price);
      Pastry cutieCupcake = new Pastry(1, price);
      Pastry croissant = new Pastry(1, price);
      Pastry notAPastryAtAll = new Pastry(1, price);
      Pastry birdFeatherPie = new Pastry(1, price);
      List<Pastry> PastryOrder = new List<Pastry> {staleCrust, cutieCupcake, croissant, notAPastryAtAll, birdFeatherPie};
      int orderPrice = 9;

      //Act
      int testOrderPrice = staleCrust.Cashier();

      //Assert
      Assert.AreEqual(orderPrice, testOrderPrice);

    }
  }
}