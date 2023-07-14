
namespace Bakery.Models
{
    public class Bread : BakedGood {

        public Bread() {
            _price = 5;
            _bogo = 2;
        }
        public override int Purchase(int quantity) {
            int cost = (_price * quantity) - _price * (quantity / 3);
            return cost;
        }
    }
}
