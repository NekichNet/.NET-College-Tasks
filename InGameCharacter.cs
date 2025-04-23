using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public class InGameCharacter
    {
        private string name_;
        private string race_;
        private IWeapon weapon_;
        private int strength_;

        public string Info()
        {
            return $"Name: {name_} Race: {race_} " +
                $"Strength: {strength_} " +
                $"Weapon Strength: {weapon_.WeaponStrength} " +
                $"Features: {weapon_.UnusualAbilities} " +
                $"{weapon_.GetInfo()}";
        }

        public int OverallStrength()
        {
            return strength_ + weapon_.WeaponStrength;
        }
    }
}
