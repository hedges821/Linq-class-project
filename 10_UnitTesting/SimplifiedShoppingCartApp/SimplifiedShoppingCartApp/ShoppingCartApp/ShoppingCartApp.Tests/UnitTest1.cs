﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartApp.Models;

public class UnitTest1
{
    private IValueCalculator getTestObject()
    {
        return new ValueAfterDiscountCalculator();
    }
    [TestMethod]
    public void Total_Above_200()
    {
        // arrange
        IValueCalculator target = getTestObject();
        Product[] productsAtThreeHundred = {
            new Product {Name = "Product1",  Price = 100M},
            new Product {Name = "Product2", Price = 200M}
            };
        // act
        var discounted300 = target.ValueProducts(productsAtThreeHundred);
        // assert
        Assert.AreEqual(270M, discounted300);
    }
    [TestMethod]
    public void Total_Between_100_And_200()
    {
        //arrange
        IValueCalculator target = getTestObject();
        Product[] productsAt100 = {
            new Product {Name = "Product1",  Price = 50M},
            new Product {Name = "Product2", Price = 50M}
            };
        Product[] productsAt150 = {
            new Product {Name = "Product3",  Price = 100M},
            new Product {Name = "Product4", Price = 50M}
            };
        Product[] productsAt200 = {
            new Product {Name = "Product5",  Price = 100M},
            new Product {Name = "Product6", Price = 100M}
            };
        // act
        decimal discounted100 = target.ValueProducts(productsAt100);
        decimal discounted150 = target.ValueProducts(productsAt150);
        decimal discounted200 = target.ValueProducts(productsAt200);
        // assert
        Assert.AreEqual(95M, discounted100, "Discount for $100 is wrong");
        Assert.AreEqual(142.5M, discounted150, "Discount for $150 is wrong");
        Assert.AreEqual(190M, discounted200, "Discount for $200 is wrong");
    }

    [TestMethod]
    public void Total_Less_Than_100()
    {
        //arrange
        IValueCalculator target = getTestObject();
        Product[] productsAtZero = {
            new Product {Name = "Product1",  Price = 0M},
            new Product {Name = "Product2", Price = 0M}
            };
        Product[] productsAtFifty = {
            new Product {Name = "Product3",  Price = 25M},
            new Product {Name = "Product4", Price = 25M}
            };
        // act
        decimal discounted0 = target.ValueProducts(productsAtZero);
        decimal discounted50 = target.ValueProducts(productsAtFifty);

        // assert
        Assert.AreEqual(0M, discounted0, "Discount for $0 is wrong");
        Assert.AreEqual(50M, discounted50, "Discount for $50 is wrong");
    }
    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void Discount_Negative_Total()
    {
        //arrange
        IValueCalculator target = getTestObject();
        Product[] productsAtNegative = {
            new Product {Name = "Product1",  Price = -10M},
            new Product {Name = "Product2", Price = 0M}
            };
        // act
        decimal discounted0 = target.ValueProducts(productsAtNegative);
    }
}