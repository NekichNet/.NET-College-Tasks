using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Credit
    {
        private string fullname_;
        private decimal contribution_;
        private decimal sum_;
        private decimal bet_;

        public static decimal operator -(Credit c, int unused)
        {
            return c.contribution_ -=  c.contribution_;
        }
        public static decimal GetBet(Credit c) { return c.contribution_; }
    }
}