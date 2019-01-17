using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.CHK
{
    class Discount
    {
        public string ItemName { get; private set; }

        public int DiscountSum { get; private set; }

        public int Condition { get; private set; }

        public string Target { get; private set; }

        public Discount(string itemName, int discountSum, int applyAmount, string target)
        {
            ItemName = itemName;
            DiscountSum = discountSum;
            Condition = applyAmount;
            Target = target;
        }
    }
}

