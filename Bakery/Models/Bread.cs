namespace Bakery.Models
{
    public class Bread
    { 
        public int Purchase { get; set; }

        public Bread(int purchase)
        {
        Purchase = purchase;
        }

        public bool AmountOfBread(int purchase)
        {
        return true;
        }
    }
} 
