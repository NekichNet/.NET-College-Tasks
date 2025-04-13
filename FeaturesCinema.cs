using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26_02_25
{
    internal class FeaturesCinema
    {
        

        public string Title { get; set; }
        public decimal Cost { get; }
        public int AmountOfViewers { get; set; }

        public string Showroom { get; }

        public string Info
        {
            get
            {
                return $"Название: {Title}\nСтоимость билета: {Cost}\nКол-во зрителей: {AmountOfViewers}\nЗал: {Showroom}";
            }
        }


        public FeaturesCinema(string title, decimal cost, int amountOfViewers, string showroom) { 
            this.Title = title;
            this.Cost = cost;
            this.AmountOfViewers = amountOfViewers;
            this.Showroom = showroom;
        }

    }
}
