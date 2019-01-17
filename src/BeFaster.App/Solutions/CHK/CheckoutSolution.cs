using System;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int Checkout(string skus)
        {
            var basket = InitBasket(skus);
        }

        private static IEquatable<StockItem> InitBasket(string skus)
        {
            throw new NotImplementedException();
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


