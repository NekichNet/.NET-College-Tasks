using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    public class Drink : CafeAssortment
    {
        private int capacity_;

        override public string Info()
        {
            return $"Position name: {posName_} Category: {category_} Cost: {cost_} Capacity: {capacity_}";
        }

        public decimal Sale(int off)
        {
            return cost_ * off;
        }
    }
}
