
namespace Bakery.Models
{
    public abstract class BakedGood {
        // Price and Bogo are set in inherited class constructors
        public int Price { get; set; }
        public int Bogo { get; set; } // how many units purchased it takes to get one free

        public int Purchase(int quantity) { // returns cost of purchasing `quantity` items
        int cost = (Price * quantity) - Price * (quantity / (Bogo + 1));
        return cost;
    }
        public abstract int PriceCheck(int quantity); // like Purchase(), but does not add to list of orders
    }
}
