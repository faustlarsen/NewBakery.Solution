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
        return true;
        }
    }
} 