using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_02_25
{
    public class Animal
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Breed { get; set; }
        public string BirthDate { get; set; }

        public virtual string Info()
        {
            return $"Животное\nИмя: {Name}\nВес: {Weight}\nПорода: {Breed}\nДата рождения: {BirthDate}";
        }
    }
}
