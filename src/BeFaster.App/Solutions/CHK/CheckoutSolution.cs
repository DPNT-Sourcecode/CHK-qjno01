using System;
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
                    default:
                        throw new ArgumentException("Invalid input");
                }
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




