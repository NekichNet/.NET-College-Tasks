using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    internal class Dish : CafeAssortment
    {
        public int Weight { get; set; }
        public int Calories { get; set; }
        override public string Info()
        {
            return $"Напиток\nИмя: {PosName}\nКатегория: {Cathegory}\nЦена: {Cost}\nВес: {Weight}\nКалории: {Calories}";
        }

        public decimal CostPerGramm()
        {
            return Weight / Cost;
        }
    }
}
