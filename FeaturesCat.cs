using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    internal class FeaturesCat
    {
        public string Name { get; set; }
        public string Breed {  get; }
        public int Height { get; set; }
        public int Age { get; set; }
        public int Weight {  get; set; }
        public string Owner {  get; } 

        public string Info
        {
            get {
                return $"Кличка: {Name}\nПорода: {Breed}\nРост: {Height}\nВозраст: {Age}\nМАССА: {Weight}\nХозяин: {Owner}";
            }
        }
    }
}
