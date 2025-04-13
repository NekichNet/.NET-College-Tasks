using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26_02_25
{
    internal class RollerCoaster : Attractions
    {
        public decimal CostPerRide { get; } = 100;

        override public string Info()
        {
            return $"Американцкее горке\nНазвание: {Name}\nДлительность поездки: {Duration}\nКол-во сидений: {Seats}";
        }

        public decimal Gain()
        {
            return CostPerRide * Seats;
        }
        public decimal Gain(int Passengers)
        {
            return CostPerRide * Passengers;
        }
    }
}
