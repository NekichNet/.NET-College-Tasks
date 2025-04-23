using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    public class FeaturesStudent
    {
        private string fullname_;
        private string group_;
        private int gradeBook_;
        private string snils_;

        public string GetInfo() { return $"Fullname: {fullname_} Group: {Group} Grade book: {GradeBook} СНИЛС: {SNILS}"; }
    }
}
