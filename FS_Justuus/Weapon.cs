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

        List<Weapon> weaponry = new List<Weapon>()
        {
            new Weapon { weaponId=1, weaponName="Rusty Knife", damageBonus = 1},
            new Weapon { weaponId=2, weaponName="Wooden Staff", damageBonus=1},
            new Weapon { weaponId=3, weaponName="Dagger", damageBonus = 2},
            new Weapon { weaponId=4, weaponName="Whip", damageBonus=2},
            new Weapon { weaponId=5, weaponName="Axe", damageBonus = 3},
            new Weapon { weaponId=6, weaponName="Silver Sword", damageBonus = 3},                      

        };
    }
}

