using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avarace_library;

namespace ConsoleApp1
{
    public class playercls
    {
        public static void NewPlayer()
        {
            Classes plrCls = Classes.Admin;
            string name, classNme = "",  raceNme = "";
            int gold = 0, hp = 0;
            bool Crace = false, Cclass = false;


            Console.WriteLine("What is your name?");
            Console.Write("-- ");
            name = Console.ReadLine();

            while (Cclass == false)
            {
                Console.WriteLine("What class would you like to be?");
                Console.Write("Swordsman, Mage, Archer -- ");
                classNme = Console.ReadLine().ToLower();
                if (classNme == "mage")
                {
                    gold = 100;
                    Cclass = true;
                }

                else if (classNme == "swordsman")
                {
                    gold = 100;
                    Cclass = true;
                }
                
                else if (classNme == "archer")
                {
                    gold = 100;
                    Cclass = true;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
            }

            while (Crace == false)
            {
                
                Console.WriteLine("What race will you choose?");
                Console.Write("Elf, Beastman, Human -- ");
                raceNme = Console.ReadLine().ToLower();

                if (raceNme == "human")
                {
                    Crace = true;
                    hp = 100;
                }
                else if (raceNme == "elf")
                {
                    Crace = true;
                    hp = 75;
                }
                else if (raceNme == "beastman")
                {
                    Crace = true;
                    hp = 125;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
            }
        }
        public static void PullPlayer()
        { 

        }
    }
}
