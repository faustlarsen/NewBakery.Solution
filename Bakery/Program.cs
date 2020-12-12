using System;
using Bakery.Models;

namespace PierresBakery
{
  public class Bakery
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Pierre's Bakery!");
      Menu();
    }
    public static void Menu()
      {
      Console.WriteLine("Would you like to buy some Bread and Pastry?");
      Console.WriteLine("BREAD: 1 for $5 or buy 2 get 1 FREE! PASTRY: 1 for $2 or 3 for $5!");
      Console.WriteLine("How many loaves of bread? (type a number");
      Bread purchaseBread = new Bread(int.Parse(Console.ReadLine()));
      int breadAmount = purchaseBread.BreadTotal();
      Console.WriteLine("And how many pastries?");
      Pastry purchasePastry = new Pastry(int.Parse(Console.ReadLine()));
      int pastryAmount = purchasePastry.PastryTotal();
      int total = (breadAmount + pastryAmount);
      Console.WriteLine("Your total is:" + " " + "$" + total);
      Console.WriteLine("Thank you for stopping by! Unless you want some more? (type 'y' or 'n')");
      string response = Console.ReadLine();
      if (response == "y")
      {
        Menu();
      }
    }
  }
}