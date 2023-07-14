using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class BakedGoodTests
    {
        [TestMethod]
        public void Bread_PurchaseOne_Int()
        {
            int quantityToPurchase = 1;
            Bread testBread = new Bread();
            
            int expectedCost = 5;

            Assert.AreEqual(expectedCost, testBread.Purchase(quantityToPurchase));
        }

        [TestMethod]
        public void Bread_PurchaseThree_Int()
        {
            int quantityToPurchase = 3;
            Bread testBread = new Bread();
            
            int expectedCost = 10;

            Assert.AreEqual(expectedCost, testBread.Purchase(quantityToPurchase));
        }
    }
}
