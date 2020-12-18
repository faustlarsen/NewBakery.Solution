namespace Bakery.Models
{
    public class Pastry
    { 
        public int Quantity { get; set; }
        public Pastry(int quantity)
        {
            Quantity = quantity;
        }
        public int PastryTotal()
        {
            int newTotal = (Quantity * 2 - (Quantity / 3));
            return newTotal;
        }
    } 
}
