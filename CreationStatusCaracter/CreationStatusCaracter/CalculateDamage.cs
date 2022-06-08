using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationStatusCaracter
{
    internal class CalculateDamage
    {
        private static Random rnd = new Random();

        public static int DamageStrongWeapon(int strong)
        {
            int rng = rnd.Next(10, 20);
            int weaponDamage = 10;
            int damage = weaponDamage + weaponDamage * strong;
            return damage;
        }

        public static int DamageDexWeapon(int dex)
        {
            int rng = rnd.Next(5, 11);
            int weaponDamage = 5;
            int damage = weaponDamage + rng * dex;
            return damage;
        }
    }
}
