namespace Bakery.Models
{
    public class Bread : BakedGood {

        public Bread() {
            Price = 5;
            Bogo = 2;
        }

        public override int PriceCheck(int quantity) {
            return (Price * quantity) - Price * (quantity / (Bogo + 1));
        }
    }
}
