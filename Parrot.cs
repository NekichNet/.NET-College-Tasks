using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26_02_25
{
    public class Parrot : Animal
    {
        override public string Info()
        {
            return $"Name: {name_} Weight: {weight_} Breed: {breed_} Birthdate: {birthdate_}";
        }
    }
}
