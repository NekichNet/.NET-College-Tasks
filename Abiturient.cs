using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Abiturient
    {
        private string fullname_;
        private double average_;
        private List<int> grades_;


        public static bool operator <(Abiturient first, Abiturient second)
        {
            if (first.average_ < second.average_) {  return true; } 
            else if(first.average_ > second.average_) { return false; }
            else
            {
                int list1Sum = first.grades_.Sum();
                int list2Sum = second.grades_.Sum();
                return list1Sum < list2Sum;
            }
        }
        public static bool operator >(Abiturient first, Abiturient second)
        {
            if (first.average_ > second.average_) { return true; }
            else if (first.average_ < second.average_) { return false; }
            else
            {
                int list1Sum = first.grades_.Sum();
                int list2Sum = second.grades_.Sum();
                return list1Sum > list2Sum;
            }
        }

        public double getAverage() { return average_; }
    }
}
