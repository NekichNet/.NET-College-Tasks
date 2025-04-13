using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    internal class CafeAssortment
    {
        public string PosName { get; set; }
        public decimal Cost { get; set; }
        public string Cathegory { get; set; }

        public virtual string Info()
        {
            return $"Ассортимент\nИмя: {PosName}\nКатегория: {Cathegory}\nЦена: {Cost}\n";
        }
    }
}
