using _19_12.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_12
{
    public class DatabaseControl
    {
        public static List<Employee> GetEmployeesList()
        {
            using (DbAppContext context = new DbAppContext())
            {
                return context.Employee.ToList();
            }
        }
    }
}
