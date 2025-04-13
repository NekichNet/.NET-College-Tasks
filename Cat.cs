using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Cat
    {
        private string name_;
        private string breed_;
        private string birthdate_;
        private double weight_;

        public static bool operator <(Cat cat1, Cat cat2)
        {
            return cat1.weight_ < cat2.weight_;
        }

        public static bool operator >(Cat cat1, Cat cat2)
        {
            return cat1.weight_ > cat2.weight_;
        }

        public static string operator *(Cat cat1, Cat cat2)
        {
            return cat1.breed_ == cat2.breed_ ? "Селекция возможна" : "Селекция невозможна";
        }

        public double getWeight() { return weight_; }
    }
}
