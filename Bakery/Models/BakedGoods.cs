
namespace Bakery.Models
{
    public abstract class BakedGood {
        // Price and Bogo are set to default values in inherited class 
        // constructors
        public int Price { get; set; }
        public int Bogo { get; set; } // how many units purchased it takes to get one free

        // returns cost of purchase
        public abstract int Purchase(int quantity);
    }
}
