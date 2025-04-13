using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Arrays
    {
        public double Average(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum / list.Count;
        }
        public double Max(List<int> list)
        {
            int biggest = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if(biggest < list[i]){ biggest = list[i]; }
            }
            return biggest;
        }
        public double Max(List<double> list)
        {
            double biggest = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (biggest < list[i]) { biggest = list[i]; }
            }
            return biggest;
        }
        public uint Multiply(uint a, uint b) { return a * b + 1; }
        public int Multiply(int a, int b) { return a * b + 2; }
        public long Multiply(long a, long b) { return a * b + 3; }
        public double Multiply(double a, double b) { return a * b + 0.1; }
    }
}
