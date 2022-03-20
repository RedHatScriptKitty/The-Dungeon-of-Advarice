/**
* 2/17/22
* CSC 153
* Noah Kolb
* Text adventure
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            bool start = false;
            int roomLocation = 0;



            string[] rooms = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List rooms.txt");
            string[] weapons = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List weapons.txt");
            string[] potions = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List potions.txt");
            string[] treasures = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List treasures.txt");
            string[] mobs = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List mobs.txt");
            string[] items = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List items.txt");


            /* //Array
             string[] rooms = new string[5] { "Entrance", "Hallway", "Atrium", "Boss room", "Treasure room" };
             string[] weapons = new string[4] { "Sword", "Glave", "Bow", "Staff" };
             string[] potions = new string[2] { "Healing pot", "Strength pot" };
             string[] Treasures = new string[3] { "Gold", "Armor", "leather boot" }; 

             //List
             List<string> Mobs = new List<string>() { "Demon", "Mimic", "Baby Wyvern", "Skeleton","lich" };
             List<string> Items = new List<string>() 
             { "Boss door key", "Strange key", "Magic book", "Torch" };
             //Hub*/


            while (exit == false)
            {
                if (start == false)
                {
                    //Console.WriteLine($"Your in - ({rooms[roomLocation]})");
                    Console.WriteLine("Type start Jump Right In");
                    Console.WriteLine("R. Display Rooms");
                    Console.WriteLine("W. Display Weapons");
                    Console.WriteLine("P. Display Potions");
                    Console.WriteLine("T. Display Treasures");
                    Console.WriteLine("M. Display Mobs");
                    Console.WriteLine("I. Display Items");
                    Console.WriteLine("Type Exit to leave");
                    Console.Write("Enter A Choice > ");
                    string input = Console.ReadLine();

                    switch (input.ToLower())
                    {


                        case "r": foreach (string line in rooms) Console.WriteLine(rooms); break;
                        //foreach(string value in rooms){Console.WriteLine(value); Console.WriteLine();} break;
                        case "w": foreach (string line in weapons) Console.WriteLine(weapons); break;
                        //foreach(string value in weapons){Console.WriteLine(value); Console.WriteLine();} break;
                        case "p": foreach (string line in potions) Console.WriteLine(potions); break;
                        //foreach(string value in potions){Console.WriteLine(value); Console.WriteLine();} break;
                        case "t": foreach (string line in treasures) Console.WriteLine(treasures); break;
                        //foreach(string value in Treasures){Console.WriteLine(value); Console.WriteLine();} break;
                        case "i": foreach (string line in items) Console.WriteLine(items); break;
                        //foreach(string value in Items){Console.WriteLine(value); Console.WriteLine();} break;
                        case "m": foreach (string line in mobs) Console.WriteLine(mobs); break;
                        //foreach(string value in Mobs){Console.WriteLine(value); Console.WriteLine();} break;
                        case "rooms": foreach (string line in rooms) Console.WriteLine(rooms); break;
                        //foreach(string value in rooms){Console.WriteLine(value); Console.WriteLine();} break;
                        case "weapons": foreach (string line in weapons) Console.WriteLine(weapons); break;
                        //foreach(string value in weapons){Console.WriteLine(value); Console.WriteLine();} break;
                        case "potions": foreach (string line in potions) Console.WriteLine(potions); break;
                        //foreach(string value in potions){Console.WriteLine(value); Console.WriteLine();} break;
                        case "treasures": foreach (string line in treasures) Console.WriteLine(treasures); break;
                        //foreach(string value in Treasures){Console.WriteLine(value); Console.WriteLine();} break;
                        case "items": foreach (string line in items) Console.WriteLine(items); break;
                        //foreach(string value in Items){Console.WriteLine(value); Console.WriteLine();} break;
                        case "mobs": foreach (string line in mobs) Console.WriteLine(mobs); break;
                        //foreach(string value in Mobs){Console.WriteLine(value); Console.WriteLine();} break;
                        //case "n": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                        //case "s": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                        case "2": exit = true; break;
                        case "leave": exit = true; break;
                        case "exit": exit = true; break;
                        case "start": start = true; break;
                        case "begin": start = true; break;

                        default: Console.WriteLine(input+" is Not an Option"); Console.WriteLine(); break;
                    }

                }
                if (start == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Your in - ({rooms[roomLocation]})");
                    Console.WriteLine("");
                    string input = Console.ReadLine();
                    switch (input.ToLower())
                    {

                        case "n": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                        case "go north": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                        case "north": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                        case "forward": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                        case "s": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                        case "go south": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                        case "south": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                        case "back": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                        case "leave": exit = true; break;
                        case "exit": exit = true; break;
                        case "start": start = true; break;
                        case "menu": start = false; break;
                        default: Console.WriteLine(input +" is Not an Option"); Console.WriteLine(); break;
                    }
                }
                else { }
            }
        }
    }
}
