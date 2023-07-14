namespace Bakery.Models
{
    public class Pastry : BakedGood {
        public Pastry() {
            Price = 2;
            Bogo = 3;
        }

    public override int PriceCheck(int quantity) {
        return (Price * quantity) - Price * (quantity / (Bogo + 1));
    }
    }
}
