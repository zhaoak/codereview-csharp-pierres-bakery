namespace Bakery.Models
{
    public class Pastry : BakedGood {
        public Pastry() {
            Price = 2;
            Bogo = 3;
        }

        public Pastry(int price, int bogo) {
            Price = price;
            Bogo = bogo;
        }
    }
}
