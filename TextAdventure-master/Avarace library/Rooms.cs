using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avarace_library
{
    public class Rooms
    {
        public static string[] RFile()
        {
            Random rand = new Random();
            int unused = rand.Next(0, 20);
            string[] rooms = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List rooms.txt");
            return (rooms);
        }
        public void movement()
        {
            string[] rooms = RFile(); 
            int roomLocation = 0;
            Console.WriteLine($"Your in - ({rooms[roomLocation]})");
            string input = Console.ReadLine();
            Console.WriteLine(" ");
            switch (input.ToLower())
            {
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
            }
        }
    }
}
   

