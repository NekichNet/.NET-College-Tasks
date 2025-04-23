using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_02_25
{
    public struct Bow : IWeapon
    {
        public int WeaponStrength { get; set; }
        public string UnusualAbilities { get; set; }

        private int distance_;
        private int accuracy_;

        string IWeapon.GetInfo()
        {
            return $"Дистанция стрельбы: {distance_} Точность: {accuracy_}";
        }
    }
}
