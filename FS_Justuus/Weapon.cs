using System;
using System.Collections.Generic;
using System.Text;

namespace FS_Justuus
{
    class Weapon
    {      

        public int weaponId { get; set; }

        public string weaponName { get; set; }

        public int damageBonus { get; set; }


        public Weapon(int nextWeaponId, string nextWeaponName, int nextDamageBonus)
        {
            weaponId = nextWeaponId;
            weaponName = nextWeaponName;
            damageBonus = nextDamageBonus;
        }
    }
}

