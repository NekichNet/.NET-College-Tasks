using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public class Accounting
    {
        public decimal CalculateTax(ISalary employee)
        {
            return employee.CalculateSalary() * (decimal)0.13;
        }
    }
}
