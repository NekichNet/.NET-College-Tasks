using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Empire
    {
        private static readonly int Population = 300000;
        private static readonly int Area = 900000;

        public static bool isEmpire(State state)
        {
            return state.getPopulation() >= Population && state.getArea() >= Area;
        }
    }
}
