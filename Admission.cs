using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public static class Admission
    {
        public static bool Passed(Abiturient abiturient)
        {
            return abiturient.getAverage() >= 4.5;
        }
    }
}
