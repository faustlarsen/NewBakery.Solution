using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    { 
        public int Purchase { get; set; }
        public Bread(int purchase)
        {
        Purchase = purchase;
        }
        
        public bool AmountOfBread()
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
        public Dictionary<string, int> BreadPrice()
        {
            Dictionary<string, int> breadPrice = new Dictionary<string, int>
            {
                {"Bread", 5}
            };
            return breadPrice;
        }
        public int BreadPrice(Dictionary<string, int> breadPrice)
            {
            int newPurchace = Purchase * 5;
            return newPurchace;
        }
    }
} 
