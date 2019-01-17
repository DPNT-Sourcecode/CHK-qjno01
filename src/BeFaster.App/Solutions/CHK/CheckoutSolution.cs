﻿using System;
using System.Collections.Generic;
using System.Linq;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int Checkout(string skus)
        {
            try
            {
                var basket = InitBasket(skus).ToList();
                var sum = basket.Sum(x => x.Price);
                var discount = CalculateDiscount(basket);
                return sum - discount;
            }
            catch (ArgumentException)
            {
                return -1;
            }

        }

        private static int CalculateDiscount(IList<StockItem> basket)
        {
            var discounts = InitDiscounts();

            //remove free items from basket 
            foreach (var discount in discounts.Where(x => x.ItemName != x.Target))
            {
                var removeCount = basket.Count(x => x.Name == discount.ItemName) /
                    discount.ApplyAmount;
                for (int i = 0; i < removeCount; i++)
                {
                    var item = basket.FirstOrDefault(x => x.Name == discount.Target);
                    if (item == null)
                        break;
                    basket.Remove(item);
                }
            }

            int total = 0;
            //discount special
            foreach (var discount in discounts)
            {
                var itemCount = basket.Count(x => x.Name == discount.ItemName);
                if (discount.Target != discount.ItemName)
                {
                    if (basket.Count(x => x.Name == discount.Target) == 0)
                        continue;
                }
                else
                    total += discount.DiscountSum *
                   (itemCount / discount.ApplyAmount);
            }
            return total;
        }

        private static IEnumerable<Discount> InitDiscounts()
        {
            var collection = new List<Discount>();
            collection.Add(new Discount("A", 20, 3, "A"));
            collection.Add(new Discount("B", 15, 2, "B"));
            collection.Add(new Discount("E", 30, 2, "B"));
            return collection;
        }


        private static IEnumerable<StockItem> InitBasket(string skus)
        {
            var collection = new List<StockItem>(skus.Length);
            foreach (var item in skus)
            {
                switch (item)
                {
                    case 'A':
                        collection.Add(new StockItem("A", 50));
                        break;
                    case 'B':
                        collection.Add(new StockItem("B", 30));
                        break;
                    case 'C':
                        collection.Add(new StockItem("C", 20));
                        break;
                    case 'D':
                        collection.Add(new StockItem("D", 15));
                        break;
                    case 'E':
                        collection.Add(new StockItem("E", 40));
                        break;
                    default:
                        throw new ArgumentException("Invalid input");
                }
            }
            return collection;
        }
    }
}

