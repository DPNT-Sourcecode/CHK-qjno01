using System;
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
                basket = ReassembleGroupDiscounts(basket);
                var discounts = InitDiscounts();
                RemoveFreeFromBasket(basket, discounts);
                var sum = basket.Sum(x => x.Price);
                var discount = CalculateDiscount(basket, discounts);
                return sum - discount;
            }
            catch (ArgumentException)
            {
                return -1;
            }

        }

        private static List<StockItem> ReassembleGroupDiscounts(List<StockItem> basket)
        {
            var groupDiscountItems = new[] { "S", "T", "X", "Y", "Z" };
            var groupDiscountProduct = new StockItem("d", 45);
            var groupBasket = basket.Where(x => groupDiscountItems.Contains(x.Name));

        }

        private static void RemoveFreeFromBasket(List<StockItem> basket, IEnumerable<Discount> discounts)
        {
            //remove free items from basket 
            foreach (var discount in discounts.Where(x => x.ItemName != x.Target))
            {
                var removeCount = basket.Count(x => x.Name == discount.ItemName) /
                    discount.Condition;
                for (int i = 0; i < removeCount; i++)
                {
                    var item = basket.FirstOrDefault(x => x.Name == discount.Target);
                    if (item == null)
                        break;
                    basket.Remove(item);
                }
            }
        }

        private static int CalculateDiscount(IList<StockItem> basket, IEnumerable<Discount> discounts)
        {
            int total = 0;
            //discount special
            foreach (var discount in discounts)
            {
                var itemCount = basket.Count(x => x.Name == discount.ItemName);
                if (discount.Target != discount.ItemName)
                {
                    continue;
                }
                else
                {
                    int discountTimes = itemCount / discount.Condition;
                    total += discount.DiscountSum * discountTimes;
                    //remove amount of item from basket
                    for (int i = 0; i < discountTimes * discount.Condition; i++)
                    {
                        var item = basket.FirstOrDefault(x => x.Name == discount.Target);
                        if (item == null)
                            break;
                        basket.Remove(item);
                    }
                }
            }
            return total;
        }

        private static IEnumerable<Discount> InitDiscounts()
        {
            var collection = new List<Discount>();
            collection.Add(new Discount("A", 50, 5, "A"));
            collection.Add(new Discount("A", 20, 3, "A"));
            collection.Add(new Discount("B", 15, 2, "B"));
            collection.Add(new Discount("E", 30, 2, "B"));
            collection.Add(new Discount("F", 10, 3, "F"));
            collection.Add(new Discount("H", 20, 10, "H"));
            collection.Add(new Discount("H", 5, 5, "H"));
            collection.Add(new Discount("K", 10, 2, "K"));
            collection.Add(new Discount("N", 15, 3, "M"));
            collection.Add(new Discount("P", 50, 5, "P"));
            collection.Add(new Discount("Q", 10, 3, "Q"));
            collection.Add(new Discount("R", 30, 3, "Q"));
            collection.Add(new Discount("U", 40, 4, "U"));
            collection.Add(new Discount("V", 20, 3, "V"));
            collection.Add(new Discount("V", 10, 2, "V"));
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
                    case 'F':
                        collection.Add(new StockItem("F", 10));
                        break;
                    case 'G':
                        collection.Add(new StockItem(item.ToString(), 20));
                        break;
                    case 'H':
                        collection.Add(new StockItem(item.ToString(), 10));
                        break;
                    case 'I':
                        collection.Add(new StockItem(item.ToString(), 35));
                        break;
                    case 'J':
                        collection.Add(new StockItem(item.ToString(), 60));
                        break;
                    case 'K':
                        collection.Add(new StockItem(item.ToString(), 70));
                        break;
                    case 'L':
                        collection.Add(new StockItem(item.ToString(), 90));
                        break;
                    case 'M':
                        collection.Add(new StockItem(item.ToString(), 15));
                        break;
                    case 'N':
                        collection.Add(new StockItem(item.ToString(), 40));
                        break;
                    case 'O':
                        collection.Add(new StockItem(item.ToString(), 10));
                        break;
                    case 'P':
                        collection.Add(new StockItem(item.ToString(), 50));
                        break;
                    case 'Q':
                        collection.Add(new StockItem(item.ToString(), 30));
                        break;
                    case 'R':
                        collection.Add(new StockItem(item.ToString(), 50));
                        break;
                    case 'S':
                        collection.Add(new StockItem(item.ToString(), 20));
                        break;
                    case 'T':
                        collection.Add(new StockItem(item.ToString(), 20));
                        break;
                    case 'U':
                        collection.Add(new StockItem(item.ToString(), 40));
                        break;
                    case 'V':
                        collection.Add(new StockItem(item.ToString(), 50));
                        break;
                    case 'W':
                        collection.Add(new StockItem(item.ToString(), 20));
                        break;
                    case 'X':
                        collection.Add(new StockItem(item.ToString(), 17));
                        break;
                    case 'Y':
                        collection.Add(new StockItem(item.ToString(), 20));
                        break;
                    case 'Z':
                        collection.Add(new StockItem(item.ToString(), 21));
                        break;
                    default:
                        throw new ArgumentException("Invalid input");
                }
            }
            return collection;
        }
    }
}



