using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public static class Workability
    {
        private static int min = 18;
        private static int max = 70;

        public static bool IsEligibleForWork(Person person)
        {
            return person.getAge() > min && person.getAge() < max;
        }
    }
}
