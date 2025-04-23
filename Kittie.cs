using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    public class Kittie : Animal
    {
        public bool CatchMouse() {             
            Random rnd = new Random();
            int rand = rnd.Next(0,100);

            return rand >= 50;
        }

        override public string Info()
        {
            return $"Name: {name_} Weight: {weight_} Breed: {breed_} Birthdate: {birthdate_}";
        }
    }
}
