
namespace Bakery.Models
{
    public class Bread : BakedGood {

        public Bread() {
            Price = 5;
            Bogo = 2;
        }

        public override int Purchase(int quantity) {
            int cost = (Price * quantity) - Price * (quantity / (Bogo + 1));
            return cost;
        }
    }
}
