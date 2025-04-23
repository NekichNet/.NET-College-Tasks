using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    private class Manager : ISalary, IPrintable
    {
        private string fullname_;
        private int workingDays_;

        public decimal CalculateSalary()
        {
            return workingDays_ * (decimal)1000;
        }

        public void Print()
        {
            Console.WriteLine($"Fullname: {fullname_}, Days: {workingDays_}, Salary: {CalculateSalary()}");
        }
    }
}