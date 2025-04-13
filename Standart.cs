using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public static class Standart
    {
        private static int students_ = 100;
        private static int teachers_ = 10;

        public static bool CheckForMatches(College college)
        {
            return college.getStudents() >= students_ &&
                college.getTeachers() >= ((college.getStudents() / students_) * teachers_);
        }
    }
}
