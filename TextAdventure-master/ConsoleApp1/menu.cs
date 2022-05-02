using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avarace_library;

namespace ConsoleApp1
{
     public class menu
    {
        public static void Menu()
        {
            bool create = false;

            Console.WriteLine("Would you like to Create a New Charecter?");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {

                case "yes": create = true; break;
                case "no": create = false; break;
                default: Console.WriteLine(input + " is Not an Option please Enter Yes or No"); Console.WriteLine(""); Program.Main(); break;
            }

            if (create == true)
            {
                playercls.NewPlayer();
            }
            else if (create == false)
            {
                playercls.PullPlayer();
            }

        }
            public static void TmpMenu()
            {
             bool exit = false;
             bool start = false
     ;
             int roomLocation = 0;
             //string[] rooms = Roomscls.tstroom();
             string[] rooms = Rooms.RFile();
             string[] weapons = Weapons.WFile();
             string[] potions = Potions.PFile();
             string[] treasures = Loot.LFile();
             string[] items = Items.IFile();
             string[] mobs = Mobs.MFile();

                 while (exit == false)
                 {
                     if (start == false)
                     {
                         //Console.WriteLine($"Your in - ({rooms[roomLocation]})");
                         Console.WriteLine("Type Start to Begin");
                         Console.WriteLine("Type Exit to leave");
                         Console.WriteLine(" ");
                         Console.WriteLine("R. Display Rooms");
                         Console.WriteLine("W. Display Weapons");
                         Console.WriteLine("P. Display Potions");
                         Console.WriteLine("T. Display Treasures");
                         Console.WriteLine("M. Display Mobs");
                         Console.WriteLine("I. Display Items");
                         Console.WriteLine(" ");
                         Console.Write("Enter A Choice > ");
                         string input = Console.ReadLine();
                         switch (input.ToLower())
                         {


                             case "r": foreach (string line in rooms) Console.WriteLine(rooms); break;                        
                             case "w": foreach (string line in weapons) Console.WriteLine(weapons); break;                       
                             case "p": foreach (string line in potions) Console.WriteLine(potions); break;                        
                             case "t": foreach (string line in treasures) Console.WriteLine(treasures); break;                        
                             case "i": foreach (string line in items) Console.WriteLine(items); break;                       
                             case "m": foreach (string line in mobs) Console.WriteLine(mobs); break;                        
                             case "rooms": foreach (string line in rooms) Console.WriteLine(rooms); break;                        
                             case "weapons": foreach (string line in weapons) Console.WriteLine(weapons); break;                        
                             case "potions": foreach (string line in potions) Console.WriteLine(potions); break;                        
                             case "treasures": foreach (string line in treasures) Console.WriteLine(treasures); break;                      
                             case "items": foreach (string line in items) Console.WriteLine(items); break;                      
                             case "mobs": foreach (string line in mobs) Console.WriteLine(mobs); break;              
                             case "n": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                             case "s": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                             case "2": exit = true; break;
                             case "leave": exit = true; break;
                             case "exit": exit = true; break;
                             case "start": start = true; break;
                             case "1": start = true; break;
                             case "begin": start = true; break;



                             default: Console.WriteLine(input + " is Not an Option"); Console.WriteLine(); break;
                         }

                     }
                     if (start == true)
                     {
                         Console.WriteLine("");
                         Console.WriteLine($"Your in - ({rooms[roomLocation]})");
                         Console.WriteLine($"Your HP is () ");
                         Console.WriteLine("");
                         Console.WriteLine("1.Move North");
                         Console.WriteLine("2.Move South");
                         Console.WriteLine("3.Attack");
                         Console.WriteLine("4.Exit");
                         Console.WriteLine(" ");
                         string input = Console.ReadLine();
                         Console.WriteLine(" ");
                         switch (input.ToLower())
                         {

                             //Avarace_RNG.Health(damage);
                             //case "5": Console.WriteLine(Avarace_RNG.Health()); break;
                             case "n": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                             case "go north": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                             case "move north": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                             case "north": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                             case "forward": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                             case "1": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                             case "s": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                             case "go south": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                             case "move south": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                             case "south": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                             case "back": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                             case "2": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;

                             //case "3": if (Avarace_RNG.AttackRNG() == 0) { Console.WriteLine("Attack Missed");} else { Console.WriteLine(Avarace_RNG.AttackRNG()+"Pts of Damage"); } break;
                             case "3": CombatClass.Damage(); break;


                             case "leave": exit = true; break;
                             case "exit": exit = true; break;
                             case "4": exit = true; break;
                             case "start": start = true; break;
                             case "menu": start = false; break;
                             default: Console.WriteLine(input + " is Not an Option"); Console.WriteLine(); break;
                         }
                     }
                     else { }
                 }


             }
        
    }
}

