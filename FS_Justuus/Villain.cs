using System;
using System.Collections.Generic;
using System.Text;

namespace FS_Justuus
{
    public class Villain
    {
        //Properties
        public string villainName { get; set; }
        public int Hp { get; set; }
        public int Lvl { get; set; }
               
        List<Villain> villainGroup = new List<Villain>()
        {
            new Villain { villainName="Clumsy, almost retired Thief", Hp=3, Lvl=1},
            new Villain { villainName="The Flexing Barbarian", Hp=5, Lvl =2},
            new Villain { villainName="The Twisted Druid", Hp=7, Lvl =3},

        };
    }
}
