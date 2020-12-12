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