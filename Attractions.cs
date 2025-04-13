using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    public class Attractions
    {
        protected string name_;
        protected string duration_;
        protected int seats_;

        public virtual string Info()
        {
            return $"Name: {name_} Duration: {duration_} Seats: {Seats}";
        }
    }
}
