using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    internal class FeaturesStudent
    {
        public string FullName { get; set; }
        public string Group { get; }
        public int GradeBook { get; }

        public string SNILS { get; }


        public string GetInfo() { return $"Имя: {FullName}\nГруппа: {Group}\nНомер зачетной книжки: {GradeBook}\nСНИЛС: {SNILS}"; }
    }
}
