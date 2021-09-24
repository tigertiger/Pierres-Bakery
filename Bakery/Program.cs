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
      Console.WriteLine("Would you like to order Bread [B] or Pastry [P]?");
      string yumType = (Console.ReadLine()).ToUpper();
      if (yumType == "B")
      {
      Console.WriteLine("How many breads would you like? [Enter a number]");
      Console.WriteLine("pssst... don't forget, every third bread is free!");
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      int loaves = int.Parse(Console.ReadLine());
      Bread yourBread = new Bread(loaves, 5);
      Console.WriteLine("Okay, that's " + loaves + " loaves of bread");
      int yourBreadTotal = yourBread.Cashier();
      Console.WriteLine("That will be $" + yourBreadTotal);
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      Console.WriteLine("Would you like to order pastries, too? [Y/N]");
      string pastriesToo = (Console.ReadLine()).ToUpper();
      if (pastriesToo == "N")
      {
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      Console.WriteLine("Your total today is: $" + yourBreadTotal);
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      Console.WriteLine("Thank you for stopping by Pierre's Bakery!");
      Console.WriteLine();
      }
      if (pastriesToo == "Y")
      {
        Console.WriteLine("How many pastries would you like? [Enter a number]");
        Console.WriteLine("(Every third pastry is $1 off! And some are even stale!)");
        Console.WriteLine("                        ");
        Console.WriteLine("                        ");
        int crubs = int.Parse(Console.ReadLine());
        Pastry yourPastry = new Pastry(crubs, 2);
        Console.WriteLine("You ordered " + crubs + " dirty old pastries");
        int yourPastryTotal = yourPastry.Cashier();
        Console.WriteLine("                        ");
        Console.WriteLine("                        ");
        int yourTotal = yourBreadTotal + yourPastryTotal;
        Console.WriteLine("                        ");
        Console.WriteLine("                        ");
        Console.WriteLine("Your total today is: $" + yourTotal);
        Console.WriteLine("                        ");
        Console.WriteLine("                        ");
        Console.WriteLine("Thank you for stopping by Pierre's Bakery!");
        Console.WriteLine();
      }
      }
      if (yumType == "P")
      {
      Console.WriteLine("How many pastries would you like? [Enter a number]");
      Console.WriteLine("(Every third pastry is $1 off! And some are even stale!)");
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      int crubs = int.Parse(Console.ReadLine());
      Pastry yourPastry = new Pastry(crubs, 2);
      Console.WriteLine("You ordered " + crubs + " dirty old pastries");
      int yourPastryTotal = yourPastry.Cashier();
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      Console.WriteLine("Your total today is: $" + yourPastryTotal);
      Console.WriteLine("                        ");
      Console.WriteLine("                        ");
      Console.WriteLine("Thank you for your order!");
      Console.WriteLine();
      }
    }
  }
}