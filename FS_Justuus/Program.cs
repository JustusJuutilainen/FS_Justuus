using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FS_Justuus
{
    class Program
    {
        //private static int prevStage;


        static void Main(string[] args)
        {

            //start music
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Tribal Ritual.wav";
            player.PlayLooping();

            Start:
            //initialize player stat variables
            int postCombatHealing = 2;
            int playerHP = 10;
            int charBaseDamage = 2;
            Console.WriteLine("What is your name, adventurer?");
            string charName = Console.ReadLine();

            int prevStage = 0;
            //randomization code

            //intro
            Console.WriteLine("\nYou, " + charName + ", are a mercenary warrior from the Kingdom of Saaria.");
            Console.WriteLine("The king Jan II has hired you to assasinate a rogue Jarl.");
            Console.WriteLine("In order to get to the Jarl, you must first dispatch of his assortment of bodyguards.");
            Console.WriteLine("You start with the first bodyguard, who you challenge to combat.\n");
            Console.ReadLine();



            //precombat
            Precombat:

            int stage = prevStage + 1;
            prevStage = stage;
            string villainName = "Test Monster";
            int villainHP = 4;
            int villainBaseDamage = 10;

            //enter combat text

            Console.WriteLine("You have encountered a wild " + villainName);
            Console.ReadLine();

            //WpnRandomization
            //To use weapon call the variables wpnUsed & wpnAB
            //remember to include also the wpn randomizer to the loop 
            //so it won't use just one weapon with all the villains

            AllWeapons weapon = new AllWeapons();
            string wpnUsed = "None";
            int wpnAB = 2;

            Random rnd = new Random();
            int rndWpn = rnd.Next(0, 15);

            foreach (var w in from wpn in weapon
                              where wpn.weaponId == rndWpn
                              select wpn)
            {
                wpnUsed = w.weaponName;
                wpnAB = w.damageBonus;
            }            

            //Villain system for combat, (villainId = current stage)
            AllVillains villain = new AllVillains();
            string crntVillain = "Test Monster";    
            int crntVillainHp = 1;
            int villainAB = 1;
            int villainBD = 1;

                foreach (var v in from vill in villain
                                  where vill.villainId == stage
                                  select vill)
                {
                    crntVillain = v.villainName;
                    crntVillainHp = v.villainHp;
                    villainAB = v.villainAttackBonus;
                    villainBD = v.villainBaseDamage;
                }                    
                            

            ////combat            

            while (playerHP > 0)
            {
                Console.WriteLine("You hit " + villainName + " for " + charBaseDamage + " damage.");
                villainHP = villainHP - charBaseDamage;
                Console.WriteLine(villainName + " has " + villainHP + " HP left.");
                Console.ReadLine();
                if (villainHP < 1)
                {
                    break;
                }

                Console.WriteLine(villainName + " attacks you for " + villainBaseDamage + " damage.");
                playerHP = playerHP - villainBaseDamage;
                Console.WriteLine(charName + " has " + playerHP + " HP left.");
                Console.ReadLine();

            }

            //death, if it happens
            if (playerHP < 1)
            {
                Console.WriteLine("\nYou have died. The Jarl no longer won't have his plans ruined.\n");
                Console.ReadKey();
                Console.WriteLine("Willing to play more?(Y/N)");
                string key = Console.ReadLine();
                if (key.StartsWith("y") | key.StartsWith("Y"))
                {
                    goto Start;
                }
                else
                {
                    goto End;
                }
            };
            //end of combat story


            Console.WriteLine("\nYou have completed level " + stage);
            playerHP = playerHP + 2;
            Console.WriteLine("You gain " + postCombatHealing + " HP.\n");

            //nextstage
            if (stage < 10)
            {
                goto Precombat;
            }





            //end texts
            Console.ReadLine();
            if (String.Equals(charName, "Timo"))
            {
                Console.WriteLine("After you have defeated the Jarl, you grab his necklace to bring to the king.");
                Console.WriteLine("After you present the necklace to the king, he shouts from his throne.");
                Console.WriteLine("'CONGRATULATIONS! YOU HAVE EARNED A COFFEE BREAK!'");
                Console.WriteLine("For this reason, the king lets you drink coffee publicly.");
            }
            else
            {
                Console.WriteLine("After you have defeated the Jarl, you grab his necklace to bring to the king.");
                Console.WriteLine("After you present the necklace to the king, he shouts from his throne.");
                Console.WriteLine("'THAT WAS THE WRONG JARL. THIS ONE WAS MY MOST LOYAL, YOU MONGREL!'");
                Console.WriteLine("For this treason, the king has you executed publicly.");
            }
            End:;

            //https://github.com/otuju004/
            //https://github.com/JustusJuutilainen/FS_Justuus
        }
    }
}