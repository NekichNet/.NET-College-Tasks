using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public struct Sword : IWeapon
    {
        public int strength_;
        public string unusualAbilities_;
        private enum Rarity
        {
            USUAL,
            GOOD,
            UNIQUE
        }
        Rarity rarity_;

        string IWeapon.GetInfo()
        {
            return $"Rarity: {rarity_}";
        }
    }
}
