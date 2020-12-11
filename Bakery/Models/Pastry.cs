using System.Collections.Generic;

namespace Bakery.Models
{
    public class Pastry
    { 
        public int Purchase { get; set; }

        public Pastry(int purchase)
        {
        Purchase = purchase;
        }
        public bool AmountOfPastry()
        {
            if (Purchase.GetType() == typeof(int))
            {
                return true;
            }
            else 
            {
            return true;
            }
        }
        public Dictionary<string, int> PastryPrice()
        {
            Dictionary<string, int> pastryPrice = new Dictionary<string, int>
            {
                {"Pastry", 2}
            };
            return pastryPrice;
        }
    } 
}