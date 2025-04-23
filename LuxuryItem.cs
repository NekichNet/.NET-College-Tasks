using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public class LuxuryItem : ITax, IConsoleOut
    {
        private static string class_;
        private decimal cost_;
        private string name_;

        public decimal AddTax()
        {
            return Cost * (decimal)0.8;
        }

        void IConsoleOut.Print()
        {
            Console.WriteLine($"Class: {class_} Name: {name_} Cost: {Cost} With tax: {AddTax()}");
        }
    }
}
