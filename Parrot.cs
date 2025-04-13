using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26_02_25
{
    internal class Parrot : Animal
    {
       
        override public string Info()
        {
            return $"Попуг\nИмя: {Name}\nВес: {Weight}\nПорода: {Breed}\nДата рождения: {BirthDate}";
        }
    }
}
