
namespace Bakery.Models
{
    public abstract class BakedGood {
        protected int _price;
        protected int _bogo; // how many units purchased it takes to get one free
        public abstract int Purchase(int quantity);
    }
}
