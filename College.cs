using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class College
    {
        private string name_;
        private int students_;
        private int classrooms_;
        private int teachers_;

      
        public static bool operator <(College college1, College college2)
        {
            if (college1.students_ != college2.students_)
            {
                return college1.students_ < college2.students_;
            }
            else
            {
                return college1.classrooms_ < college2.classrooms_;
            }
        }

        public static bool operator >(College college1, College college2)
        {
            if (college1.students_ != college2.students_)
            {
                return college1.students_ > college2.students_;
            }
            else
            {
                return college1.classrooms_ > college2.classrooms_;
            }
        }

        public int getStudents() { return students_; }
        public int getClassrooms() { return classrooms_; }
        public int getTeachers() { return teachers_; }
    }
}
