using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Ingredient
    {
        public string name_;
        public string effect_;
        public decimal price_;

        public Ingredient(string name, string effect, decimal price)
        {
            name_ = name;
            effect_ = effect;
            price_ = price;
        }

        public static bool operator <(Ingredient a, Ingredient b)
        {
            return a.price_ < b.price_;
        }

        public static bool operator >(Ingredient a, Ingredient b)
        {
            return a.price_ > b.price_;
        }

        public static Ingredient operator +(Ingredient a, Ingredient b)
        {
            return new Ingredient("Potion", a.effect_ + " + " + b.effect_, (a.price_ + b.price_) * 3);
        }
    }
}
