using System;
using System.Collections.Generic;
using System.Text;

namespace FS_Justuus
{
    public class Villain
    {
        //Properties
        public int villainId { get; set; }
        public string villainName { get; set; }
        public int villainHp { get; set; }
        public int villainLvl { get; set; }
        
               
        List<Villain> villainGroup = new List<Villain>()
        {
            new Villain { villainId=1, villainName="Drunkard", villainHp=3, villainLvl=1},
            new Villain { villainId=2, villainName="Maniac", villainHp=4, villainLvl=1},
            new Villain { villainId=3, villainName="Retired Thief", villainHp=5, villainLvl=2},
            new Villain { villainId=4, villainName="Cursed Kid", villainHp=6, villainLvl =2},            
            new Villain { villainId=5, villainName="Irritated Pirate", villainHp=7, villainLvl =3},
            new Villain { villainId=6, villainName="Flexing Barbarian", villainHp=8, villainLvl =3},            
            new Villain { villainId=7, villainName="Twisted Druid", villainHp=9, villainLvl =4},
            new Villain { villainId=8, villainName="Injured Berserker", villainHp=10, villainLvl =4},            
            new Villain { villainId=9, villainName="Psychotic Priest", villainHp=12, villainLvl =5},
            new Villain { villainId=10, villainName="The Jarl", villainHp=15, villainLvl =6},
        };                        
    }
}
