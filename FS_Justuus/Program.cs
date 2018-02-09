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
            Start:        
            
            bool Death = false;

            //initialize player stat variables
            int playerHP = 10;
            Console.WriteLine("What is your name, adventurer?");
            string charName = Console.ReadLine();


            //randomization code

            //precombat

            int prevStage = 0;

            int stage = prevStage + 1;
            prevStage = stage;


            //enter combat text

            //combat
            AllWeapons weapon = new AllWeapons();

            Random rnd = new Random();
            int rndWpn = rnd.Next(0, 15);

            foreach (var w in from wpn in weapon
                              where wpn.weaponId == rndWpn
                              select wpn)
            {
                Console.WriteLine("Weapon name: " + w.weaponName + ", Damage bonus: " + w.damageBonus);
            }

            //end of combat story

            //death, if it happens


            if (playerHP <= 0)
                {
                    Death = true;
                    if (Death == true)
                    {
                        Console.WriteLine("You fought well "+ charName + ", but it wasn't enough...");
                        Console.ReadKey();
                        Console.WriteLine("Willing to play more?(Y/N)");
                        string key = Console.ReadLine();
                        if (key.StartsWith( "y") | key.StartsWith("Y"))
                        {
                            goto Start;
                        }
                        else
                        {

                        };

                    };
                }

                else
                {

                };
            }        

            //end texts
        }       
    }
