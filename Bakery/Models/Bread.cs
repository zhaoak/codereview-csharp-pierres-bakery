namespace Bakery.Models
{
    public class Bread : BakedGood {

        public Bread() {
            Price = 5;
            Bogo = 2;
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
