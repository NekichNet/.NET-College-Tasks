using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    internal class Kittie : Animal
    {
        public bool CatchMouse() {             
            Random rnd = new Random();
            int rand = rnd.Next(0,100);

            if (rand < 50) { return false; }
            else{ return true; }

        }

        override public string Info()
        {
            return $"Китя\nИмя: {Name}\nВес: {Weight}\nПорода: {Breed}\nДата рождения: {BirthDate}";
        }
    }
}
