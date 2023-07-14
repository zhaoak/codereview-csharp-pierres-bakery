namespace Bakery.Models
{
    public class Bread : BakedGood {

        public Bread() {
            Price = 5;
            Bogo = 2;
        }

        public Bread(int price, int bogo)
        {
            Price = price;
            Bogo = bogo;
        }
    }
}
