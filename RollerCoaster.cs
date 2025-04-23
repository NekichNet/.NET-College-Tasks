using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26_02_25
{
    public class RollerCoaster : Attractions
    {
        private decimal costPerRide_ = 100;

        override public string Info()
        {
            return $"Name: {name_} Duration: {duration_} Seats: {seats_}";
        }

        public decimal Gain()
        {
            return costPerRide_ * seats_;
        }

        public decimal Gain(int passengers)
        {
            return costPerRide_ * passengers;
        }
    }
}
