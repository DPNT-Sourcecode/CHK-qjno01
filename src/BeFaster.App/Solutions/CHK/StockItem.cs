using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.CHK
{
    class StockItem
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
