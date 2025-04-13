using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    internal class Drink : CafeAssortment
    {
        public int Capacity { get; set; }
        override public string Info()
        {
            return $"Напиток\nИмя: {PosName}\nКатегория: {Cathegory}\nЦена: {Cost}\nОбьем напитка: {Capacity}";
        }

        public decimal Sale(int offInPercents)
        {
            return Cost * (offInPercents/100);
        }

    }
}
