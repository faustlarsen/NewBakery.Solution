using System.Collections.Generic;

namespace Bakery.Models
{
    public class Pastry
    { 
        public int Quantity { get; set; }
        public Pastry(int quantity)
        {
            Quantity = quantity;
        }
        
        //     public bool AmountOfPastry()
        // {
        //     if (Quantity.GetType() == typeof(int))
        //     {
        //     return true;
        //     }
        //     else 
        //     {
        //     return false;
        //     }
        // }
        //     public Dictionary<string, int> PastryPrice()
        // {
        //     Dictionary<string, int> pastryPrice = new Dictionary<string, int>
        //     {
        //         {"Pastry", 2}
        //     };
        //     return pastryPrice;
        // }
            public int PastryTotal()
        {
            int newTotal = (Quantity * 2 - (Quantity / 3));
            return newTotal;
        }
    } 
}
