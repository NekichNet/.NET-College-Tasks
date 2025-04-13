using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public static class WeightCategories
    {
        private static ushort smallWeight_ = 1;
        private static ushort mediumWeight_ = 3;
        private static ushort largeWeight_ = 5;


        public static string CheckWeight(Cat cat)
        {
            if (cat.getWeight() < smallWeight_)
            {
                return "Котик очень худой";
            }
            else if (cat.getWeight() >= smallWeight_ && cat.getWeight() < mediumWeight_)
            {
                return "Котик худой";
            }
            else if (cat.getWeight() >= mediumWeight_ && cat.getWeight() < largeWeight_)
            {
                return "Котик полноват";
            }
            else
            {
                return "Котик полный";
            }
        }
    }
}
