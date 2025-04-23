using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    public class Dish : CafeAssortment
    {
        private int weight_ { get; set; }
        private int calories_ { get; set; }

        override public string Info()
        {
            return $"Position name: {posName_} Category: {category_} Cost: {cost_} Weight: {weight_} Calories: {calories_}";
        }

        public decimal CostPerGramm()
        {
            return weight_ / cost_;
        }
    }
}
