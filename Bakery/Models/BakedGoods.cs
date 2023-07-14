
namespace Bakery.Models
{
    public abstract class BakedGood {
        public int Price { get; set; }
        public int Bogo { get; set; } // how many units purchased it takes to get one free
        public abstract int Purchase(int quantity);
    }
}
