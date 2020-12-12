using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    { 
        public int Quantity { get; set; }
        public Bread(int quantity)
        {
            Quantity = quantity;
        }
            public bool AmountOfBread()
        {
            if (Quantity.GetType() == typeof(int))
            {
            return true;
            }
            else 
            {
            return false;
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
            public int BreadTotal()
        {
            if (Quantity >= 3)
            {
                int buyTwoGetOneFree = (Quantity * 5) - ((Quantity / 3) * 5);
                return buyTwoGetOneFree;
            }
            else
            {
            int newTotal = Quantity * 5;
            return newTotal;
            }
        }
    }
}