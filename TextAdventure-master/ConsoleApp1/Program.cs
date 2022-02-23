/**
* 2/17/22
* CSC 153
* Noah Kolb
* Text adventure
*/

using System;
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
            int roomLocation = 0;
            //Array
            string[] rooms = new string[5] { "Entrance", "Hallway", "Atrium", "Boss room", "Treasure room" };
            string[] weapons = new string[4] { "Sword", "Glave", "Bow", "Staff" };
            string[] potions = new string[2] { "Healing pot", "Strength pot" };
            string[] Treasures = new string[3] { "Gold", "Armor", "leather boot" }; 

            //List
            List<string> Mobs = new List<string>() { "Demon", "Mimic", "Baby Wyvern", "Skeleton","lich" };
            List<string> Items = new List<string>() 
            { "Boss door key", "Strange key", "Magic book", "Torch" };
            //Hub
            while (exit == false) 
            {
                Console.WriteLine($"Your in - ({rooms[roomLocation]})");
                Console.WriteLine("R. Display Rooms");
                Console.WriteLine("W. Display Weapons");
                Console.WriteLine("P. Display Potions");
                Console.WriteLine("T. Display Treasures");
                Console.WriteLine("M. Display Mobs");
                Console.WriteLine("I. Display Items");
                Console.WriteLine("1. Jump Right In");
                Console.WriteLine("2. Exit");
                Console.Write("Enter A Choice > ");
                string input = Console.ReadLine();
                /*if (input == "1")
                {
                    //TODO
                }
                else if (input == "2")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Not an Option");
                }*/
                switch(input.ToLower())
                {
                    case "r": foreach(string value in rooms){Console.WriteLine(value); Console.WriteLine();} break;
                    case "w": foreach(string value in weapons){Console.WriteLine(value); Console.WriteLine();} break;
                    case "p": foreach(string value in potions){Console.WriteLine(value); Console.WriteLine();} break;
                    case "t": foreach(string value in Treasures){Console.WriteLine(value); Console.WriteLine();} break;
                    case "i": foreach(string value in Items){Console.WriteLine(value); Console.WriteLine();} break;
                    case "m": foreach(string value in Mobs){Console.WriteLine(value); Console.WriteLine();} break;
                    case "rooms": foreach(string value in rooms){Console.WriteLine(value); Console.WriteLine();} break;
                    case "weapons": foreach(string value in weapons){Console.WriteLine(value); Console.WriteLine();} break;
                    case "potions": foreach(string value in potions){Console.WriteLine(value); Console.WriteLine();} break;
                    case "treasures": foreach(string value in Treasures){Console.WriteLine(value); Console.WriteLine();} break;
                    case "items": foreach(string value in Items){Console.WriteLine(value); Console.WriteLine();} break;
                    case "mobs": foreach(string value in Mobs){Console.WriteLine(value); Console.WriteLine();} break;
                    case "n": if(roomLocation != 4 ) {roomLocation++; } else {Console.WriteLine("You can't go North"); Console.WriteLine();} break;
                    case "s": if(roomLocation != 0 ) {roomLocation--;} else {Console.WriteLine("You can't go South"); Console.WriteLine();} break;
                    case "2": exit = true; break;
                    case "leave": exit = true; break;
                    case "exit": exit = true; break;
                    default: Console.WriteLine("That is Not an Option"); Console.WriteLine(); break;
                }
            }
        }
    }
}
