using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {

    public int Price { get; set; }
    public static List<Bread> BreadOrder = new List<Bread> {};

    public static List<Bread> GetAll()
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
    }

  }
}