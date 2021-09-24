using System.Collections.Generic;
using System;
using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {

    public int Price { get; set; }
    public int Loaves {get ; set; }
    public int OrderPrice { get; set; }
    public static List<Bread> BreadOrder = new List<Bread> {};

    public Bread(int loaves, int price)
    {
      Price = 5;
      BreadOrder.Add(this);
      Loaves = loaves;
    }

    public static List<Bread> GetYourBreads()
    {
      return BreadOrder;
    }

    public static void ClearAll()
    {
      BreadOrder.Clear();
    }

    public int Cashier() {

      int CustOrder = Loaves * (BreadOrder.Count);

      if (CustOrder > 2) 
      {
      return (CustOrder * 5) - (CustOrder/3*5);
      }
      else 
      {
      return CustOrder * Price;
      }
    }

    // public int Cashier() {
    //   if (Loaves > 2) 
    //   {
    //   return (Loaves * 5) - (Loaves/3*5);
    //   }
    //   else 
    //   {
    //   return Loaves * Price;
    //   }
    // }

  }
}

/* 
Loaves * 5 - Loaves/3*5
5 5 X 5 5 X
5 5 X 5 5
5 5 X 5
5 5 X
5 5
5
*/