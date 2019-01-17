﻿using System;
using System.Collections.Generic;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int Checkout(string skus)
        {
            var basket = InitBasket(skus);
        }

        private static IEnumerable<StockItem> InitBasket(string skus)
        {
            var collection = new List<StockItem>(skus.Length);
            foreach (var item in skus)
            {
                if (item.Equals("A"))
            }
        }

        public class StockItem
        {
            public string Name { get; private set; }

            public int Price { get; private set; }

            public StockItem(string name, int price)
            {
                Name = name;
                Price = price;
            }
        }
    }
}



