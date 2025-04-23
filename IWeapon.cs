using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public interface IWeapon
    {
        public static string Type;
        public int Strength;
        public string UnusualAbilities;
        
        public string GetWeaponType() { return Type; }

        public virtual string GetInfo();
    }
}
