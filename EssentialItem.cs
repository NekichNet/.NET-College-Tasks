using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public class EssentialItem : ITax, IConsoleOut
    {
        public static string class_;
        public decimal cost_;
        public string name_;

        public decimal AddTax()
        {
            return cost_ * (decimal)0.995;
        }

        void IConsoleOut.Print()
        {
            Console.WriteLine($"Class: {class_} Name: {name_} Cost: {cost_} With tax: {AddTax()}");
        }
    }
}