namespace Bakery.Models
{
    public class Pastry : BakedGood {
        public Pastry() {
            Price = 2;
            Bogo = 3;
        }

    public override int Purchase(int quantity) {
        int cost = (Price * quantity) - Price * (quantity / (Bogo + 1));
        // also add order to static class list of orders
        return cost;
    }

    public override int PriceCheck(int quantity) {
        return (Price * quantity) - Price * (quantity / (Bogo + 1));
    }
    }
}
