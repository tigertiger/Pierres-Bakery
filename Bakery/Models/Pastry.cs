using System.Collections.Generic;
using System;
using System.Linq;

namespace Bakery.Models
{
  public class Pastry
  {

    public int Price { get; set; }
    public int Crubs {get ; set; }
    public int OrderPrice { get; set; }
    public static List<Pastry> PastryOrder = new List<Pastry> {};

    public Pastry(int crubs, int price)
    {
      Price = 5;
      PastryOrder.Add(this);
      Crubs = crubs;
    }

    public static List<Pastry> GetYourPastries()
    {
      return PastryOrder;
    }

    public static void ClearAll()
    {
      PastryOrder.Clear();
    }

    public int Cashier() {

      int CustOrder = Crubs * (PastryOrder.Count);

      if (CustOrder > 2) 
      {
      return (CustOrder * 5) - (CustOrder/3*5);
      }
      else 
      {
      return CustOrder * Price;
      }
    }

  }
}
/*
1: $2
2: $4
3: $5
4: $7
5: $9
6: $10
Every 3rd pastry is -$1
*/