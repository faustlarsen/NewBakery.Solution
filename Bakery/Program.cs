using System;
using Bakery.Models;

namespace PierresBakery
{
  public class Bakery
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Pierre's Bakery!");
      Console.WriteLine("Would you like to buy some bread?");
      Console.WriteLine("How many? 1 for $5 or buy 2 get 1 free?");
      Bread purchase = new Bread(int.Parse(Console.ReadLine()));
      int breadAmount = purchase.BreadTotal();
      Console.WriteLine(breadAmount);
      
    }
  }
}
