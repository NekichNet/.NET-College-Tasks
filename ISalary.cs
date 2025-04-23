using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public interface ISalary
    {
        public string FullName;
        public int WorkingDays;
        public decimal CalculateSalary();
    }
}