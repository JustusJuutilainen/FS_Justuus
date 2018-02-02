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
        public int Hp { get; set; }
        public int Lvl { get; set; }
        
               
        List<Villain> villainGroup = new List<Villain>()
        {
            new Villain { villainId=1, villainName="Drunkard", Hp=3, Lvl=1},
            new Villain { villainId=5, villainName="Maniac", Hp=4, Lvl=1},
            new Villain { villainId=2, villainName="Retired Thief", Hp=5, Lvl=2},
            new Villain { villainId=3, villainName="Flexing Barbarian", Hp=7, Lvl =3},
            new Villain { villainId=4, villainName="Twisted Druid", Hp=9, Lvl =4},
            
        };
    }
}
