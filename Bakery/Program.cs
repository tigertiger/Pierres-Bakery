using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("      **  Welcome to Pierre's Bakery  **");
      Console.WriteLine(" Where we like to say, 'Every Third Bread is Free!'");
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("--------------------  Menu  --------------------");
      Console.WriteLine("-----------------   Bread: $5  -----------------");
      Console.WriteLine("-----------------  Pastry: $2  -----------------");
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
          Console.WriteLine("* Here we assume you pay and are given your bread *");
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
          Console.WriteLine("Okay, you'd like " + crubs + " dirty old pastries?");
          int yourPastryTotal = yourPastry.Cashier();
          Console.WriteLine("That will be $" + yourPastryTotal);
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          int yourTotal = yourBreadTotal + yourPastryTotal;
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          Console.WriteLine("If that's all, your total today is: $" + yourTotal);
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          Console.WriteLine("* Here we assume you pay and are given your goodies *");
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
        Console.WriteLine("Okay, that's " + crubs + " dirty old pastries");
        int yourPastryTotal = yourPastry.Cashier();
        Console.WriteLine("That will be $" + yourPastryTotal);
        Console.WriteLine("                        ");
        Console.WriteLine("                        ");
        Console.WriteLine("Would you like to order bread, too? [Y/N]");
        string breadToo = (Console.ReadLine()).ToUpper();
        if (breadToo == "N")
        {
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          Console.WriteLine("Your total today is: $" + yourPastryTotal);
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          Console.WriteLine("* Here we assume you pay and are given your pastries *");
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          Console.WriteLine("Thank you for stopping by Pierre's Bakery!");
          Console.WriteLine();
        }
        if (breadToo == "Y")
        {
          Console.WriteLine("How many loaves would you like? [Enter a number]");
          Console.WriteLine("pssst... don't forget, every third bread is free!");
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          int loaves = int.Parse(Console.ReadLine());
          Bread yourBread = new Bread(loaves, 5);
          Console.WriteLine("Okay, you'd like " + loaves + " loaves of bread?");
          int yourBreadTotal = yourBread.Cashier();
          Console.WriteLine("That will be $" + yourBreadTotal);
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          int yourTotal = yourBreadTotal + yourPastryTotal;
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          Console.WriteLine("If that's all, your total today is: $" + yourTotal);
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          Console.WriteLine("* Here we assume you pay and are given your goodies *");
          Console.WriteLine("                        ");
          Console.WriteLine("                        ");
          Console.WriteLine("Thank you for stopping by Pierre's Bakery!");
          Console.WriteLine();
        }
      }
    }
  }
}