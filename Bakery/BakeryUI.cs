using System;
using Bakery.Models;

namespace Bakery {
    class BakeryUI
    {
        static void Main() {
            Bread freshBakedBread = new Bread(); // mmmm nice and hot
            Pastry freshBakedPastry = new Pastry(); // default constructor uses prices specified on project page
            int orderCost = 0;
            char menuChoice = '0'; // initial value doesn't matter, it just needs to get past while loop condition

            Console.WriteLine("Welcome to the C# Bakery! Fresh baked Objects of all kind, available here!");
            Console.WriteLine("Just between you and me, some of them are a little too abstract for me.\n");
            Console.WriteLine($"Today, bread costs ${freshBakedBread.Price}, and for every {freshBakedBread.Bogo} loaves you buy, you get one free!");
            Console.WriteLine($"Similar deal with pastries--${freshBakedPastry.Price} each, and buying {freshBakedPastry.Bogo} gets you one for free.");
            Console.WriteLine("Would you like to purchase anything?");

            while (menuChoice != 'D')
            {
                // menu selection
                menuChoice = chooseBakedGood();

                // leaving without purchasing
                if (menuChoice == 'Q')
                {
                    Console.WriteLine("Bye!");
                    return;
                }

                // purchasing an item
                if (menuChoice == 'B' || menuChoice == 'P')
                {
                    int itemQuantity = chooseQuantity();
                    if (menuChoice == 'B')
                    {
                        orderCost = orderCost + freshBakedBread.PriceCheck(itemQuantity);
                    }
                    else
                    {
                        orderCost = orderCost + freshBakedPastry.PriceCheck(itemQuantity);
                    }
                }

                // unknown menu selection
                if (menuChoice != 'D' && menuChoice != 'B' && menuChoice != 'P')
                {
                    Console.WriteLine("I'm...not sure what that means.");
                }
                
                if (menuChoice != 'D')
                {
                    Console.WriteLine("Anything else?");
                }
            }

            Console.WriteLine($"Your order total comes to ${orderCost}. Thanks for supporting your local .NET businesses!");
            Console.WriteLine("Wait, nobody wrote the payment processing code yet? Uhh...");
            Console.WriteLine("Dang.");
        }

        static char chooseBakedGood()
        {
            Console.WriteLine("(Enter 'B' for bread, 'P' for pastries, 'D' if you're done with your order and ready to pay, or 'Q' to leave.)");
            char menuChoice = Console.ReadLine().ToUpper()[0];
            return menuChoice;
        }

        static int chooseQuantity()
        {
            Console.WriteLine("Okay, how many?");
            int orderQuantity = 0;
            while (orderQuantity < 1)
            {
                try
                {
                    orderQuantity = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Is that...are you sure that's a number? Say it again?");
                    continue;
                }
                if (orderQuantity < 1)
                {
                    Console.WriteLine("I can't sell you less than one of those. Try again?");
                }
            }
            return orderQuantity;
        }
    }
}
