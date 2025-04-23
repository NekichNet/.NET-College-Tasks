using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public interface ITax
    {
        public virtual decimal AddTax();
        public decimal cost_;
        public string name_;
        public static string class_;
    }
}
