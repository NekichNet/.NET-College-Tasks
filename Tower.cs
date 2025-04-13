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
            return cost_ * Seats;
        }
        public decimal Gain(int Passengers)
        {
            return cost_ * Passengers;
        }

        override public string Info()
        {
            return $"Name: {Name} Duration: {Duration} Seats: {Seats}";
        }
    }
}
