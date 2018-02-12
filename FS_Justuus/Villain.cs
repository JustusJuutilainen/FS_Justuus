using System;
using System.Collections.Generic;
using System.Text;

namespace FS_Justuus
{
    class Villain
    {

        public int villainId { get; set; }

        public string villainName { get; set; }

        public int villainHp { get; set; }

        public int villainBaseDamage { get; set; }

        public int villainAttackBonus { get; set; }


        public Villain(int nextVillainId, string nextVillainName, int nextVillainHP, int nextVillainBaseDamage, int nextvillainAttackBonus)
        {
            villainId = nextVillainId;
            villainName = nextVillainName;
            villainHp = nextVillainHP;
            villainBaseDamage = nextVillainBaseDamage;
            villainAttackBonus = nextvillainAttackBonus;
        }
    }
}
