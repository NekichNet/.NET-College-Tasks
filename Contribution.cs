using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Contribution
    {
        private string fullname_;
        private decimal sum_;
        private static decimal bet_; // [0; 1]

        public static decimal operator ++(Contribution c, int _)
        {
            return c.sum_ += c.sum_ * bet_;
        }
        public static decimal getBet() { return bet_; } 
    }
}
