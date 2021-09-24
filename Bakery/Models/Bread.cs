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

    public static List<Bread> GetYourBreads()
    {
      return BreadOrder;
    }

    public static void ClearAll()
    {
      BreadOrder.Clear();
    }

    public Bread(int price)
    {
      Price = 5;
      BreadOrder.Add(this);
      Loaves = 2;
      OrderPrice = Loaves * Price;
    }

  }
}