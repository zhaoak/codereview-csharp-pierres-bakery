namespace Bakery.Models
{
    public class Pastry : BakedGood {
        public Pastry() {
            Price = 2;
            Bogo = 3;
        }

    public override int Purchase(int quantity) {
        int cost = (Price * quantity) - Price * (quantity / (Bogo + 1));
        return cost;
    }
    }
}
