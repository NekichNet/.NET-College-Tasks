using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    public class Tower : Attractions
    {
        private decimal cost_ = 100;

        public decimal Gain()
        {
            return cost_ * seats_;
        }

        public decimal Gain(int passengers)
        {
            return cost_ * passengers;
        }

        override public string Info()
        {
            return $"Name: {name_} Duration: {duration_} Seats: {seats_}";
        }
    }
}
