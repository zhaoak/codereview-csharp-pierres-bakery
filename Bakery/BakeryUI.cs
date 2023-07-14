using System;
using Bakery.Models;

namespace Bakery {
    class BakeryUI
    {
        static void Main() {
            Bread freshBakedBread = new Bread(); // mmmm nice and hot
            Pastry freshBakedPastry = new Pastry(); // default constructor uses prices specified on project page
            Console.WriteLine("Welcome to the C# Bakery! Fresh baked Objects of all kind, available here!");
            Console.WriteLine("Just between you and me, some of them are a little too abstract for me.");
            Console.WriteLine($"Today, bread costs ${freshBakedBread.Price}, and for every {freshBakedBread.Bogo} loaves you buy, you get one free!");
            Console.WriteLine($"Similar deal with pastries--${freshBakedPastry.Price} each, and buying {freshBakedPastry.Bogo} gets you one for free.");
        }
    }
}
