using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public struct Employee
    {
        private string lastname_;
        private string firstname_;
        private string surname_;
        private string position_;
        private int yearOfHiring_;

        public string Info()
        {
            return $"Fullname: {lastname_} {firstname_} {surname_} Должность: {position_} Год нанятия: {yearOfHiring_}";
        }

        public int GetExperience(int currentYear)
        {
            return currentYear - YearOfHiring;
        }
    }
}
