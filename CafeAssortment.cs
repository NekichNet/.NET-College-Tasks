using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    public class CafeAssortment
    {
        protected string posName_;
        protected decimal cost_;
        protected string category_;

        public virtual string Info()
        {
            return $"Position name: {posName_} Category: {category_} Cost: {cost_}";
        }
    }
}
