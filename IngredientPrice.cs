using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    internal static class IngredientPrice
    {
        private static int low = 100;
        private static int medium = 500;
        private static int high = 1500;

        public static string CheckPrice(Ingredient ingredient)
        {
            if (ingredient.price_ < low)
            {
                return "Cost is too small";
            }
            else if (ingredient.price_ < medium)
            {
                return "Cost is small";
            }
            else if (ingredient.price_ < high)
            {
                return "It's expensive";
            }
            else
            {
                return "It's too expensive";
            }
        }
    }

}
