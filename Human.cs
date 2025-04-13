using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Person
    {
        private string fullname_;
        private string gender_;
        private int age_;
        private string eyeColor_;


        private static string DetermineChildEyeColor(string eyeColor1, string eyeColor2)
        {
            short eye1 = convertEye(eyeColor1);
            short eye2 = convertEye(eyeColor2);
            return convertEye((short)(eye1 + eye2));
        }

        public static string operator +(Person p1, Person p2)
        {
            return DetermineChildEyeColor(p1.eyeColor_, p2.eyeColor_);
        }

        public int getAge() { return age_; }

        private static string convertEye(short color)
        {
            return color < 0 ? "Blue" : color == 0 ? "Green" : "Brown";
        }
        private static short convertEye(string color)
        {
            return (short)(color == "Blue" ? -1 : color == "Green" ? 0 : 2);
        }
    }
}
