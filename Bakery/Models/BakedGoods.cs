
namespace Bakery.Models
{
    public abstract class BakedGood {
        protected int price;
        protected int bogo; // how many units purchased it takes to get one free
        public abstract int purchase(int quantity);
    }
}
