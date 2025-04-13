using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Numbers
    {
        public static int Method1(int x, int y)
        {
            return x > y ? x : y;
        }
        public static int Method1(int x, int y, int z)
        {
            return Method1(Method1(x, y), z);
        }
        public static int Method1(int x, int y, int z, int j)
        {
            return Method1(Method1(Method1(x, y), z), j);
        }
        public static int Method1(int x, int y, int z, int j, int d)
        {
            return Method1(Method1(Method1(Method1(x, y), z), j), d);
        }
    }
}
