using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      // List<Bread> BreadOrder = new List<Bread> {};
      
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("      **  Welcome to Pierre's Bakery  **");
      Console.WriteLine(" Where we like to say, 'Every Third Bread is Free!'");
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      Console.WriteLine("How many breads would you like? [Enter a number]");
      Console.WriteLine("pssst... don't forget, every third bread is free!");
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      int loaves = int.Parse(Console.ReadLine());
      Bread yourBread = new Bread(loaves, 5);
      Console.WriteLine("You ordered " + loaves + " loaves of bread");
      int yourBreadTotal = yourBread.Cashier();
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      // int yourTotal = yourBreadTotal + yourPastryTotal;
      // Console.WriteLine("                        ");
      // Console.WriteLine("                        ");
      Console.WriteLine("Your total today is: $" + yourBreadTotal);
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      Console.WriteLine("Thank you for your order!");
      Console.WriteLine();
    }
  }
}