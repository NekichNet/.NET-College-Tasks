using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public class DepartmentHead : ISalary, IPrintable
    {
        private string fullname_;
        private int workingDays_;

        public decimal CalculateSalary()
        {
            return workingDays * (decimal)2500;
        }

        public void Print()
        {
            Console.WriteLine($"Fullname: {fullname} Days: {workingDays_} Salary: {CalculateSalary()}");
        }
    }
}
