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

        [TestMethod]
        public void Bread_PurchaseEight_Int()
        {
            int quantityToPurchase = 8;
            Bread testBread = new Bread();
            
            int expectedCost = 30;

            Assert.AreEqual(expectedCost, testBread.Purchase(quantityToPurchase));
        }

        [TestMethod]
        public void Bread_PurchaseFive_Int()
        {
            int quantityToPurchase = 5;
            Bread testBread = new Bread();
            
            int expectedCost = 20;

            Assert.AreEqual(expectedCost, testBread.Purchase(quantityToPurchase));
        }

        // Pastry tests =====================
        [TestMethod]
        public void Pastry_PurchaseOne_Int()
        {
            int quantityToPurchase = 1;
            Pastry testPastry= new Pastry();
            
            int expectedCost = 2;

            Assert.AreEqual(expectedCost, testPastry.Purchase(quantityToPurchase));
        }

        [TestMethod]
        public void Pastry_PurchaseFour_Int()
        {
            int quantityToPurchase = 4;
            Pastry testPastry= new Pastry();
            
            int expectedCost = 6;

            Assert.AreEqual(expectedCost, testPastry.Purchase(quantityToPurchase));
        }

        [TestMethod]
        public void Pastry_PurchaseNine_Int()
        {
            int quantityToPurchase = 9;
            Pastry testPastry= new Pastry();
            
            int expectedCost = 14;

            Assert.AreEqual(expectedCost, testPastry.Purchase(quantityToPurchase));
        }
    }
}
