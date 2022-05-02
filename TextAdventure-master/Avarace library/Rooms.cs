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
        

    

        private string _id, _name, _description;
        public static string[] RFile()
        {
            //StreamReader inputfile;

            Random rand = new Random();
            int unused = rand.Next(0, 20);
            string[] rooms = File.ReadAllLines(@"C:\Users\NoahC\source\repos\The-Dungeon-of-Advarice\txt adventure list\List rooms.txt");
            //string[] rooms = File.ReadAllLines("List rooms.txt");


            return (rooms);
        }
        public Rooms()
        {
            _id = "0";
            _name = "";
            _description = "";
        }
        public Rooms(string id, string name, string description, string  lighting)
        {
            ID = id;
            _name = name;
            _description = description;
            Lighting = lighting;
        }
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Lighting { get; set; } = "dim";

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
                //case "1": if (roomLocation != 4) { roomLocation++; } else { Console.WriteLine("You can't go North"); Console.WriteLine(); } break;
                case "s": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                case "go south": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                case "move south": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                case "south": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                case "back": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                //case "2": if (roomLocation != 0) { roomLocation--; } else { Console.WriteLine("You can't go South"); Console.WriteLine(); } break;
                //case "e"
                //case "3"
                //case "w"
                //case "4"
               
            }
        }
    }
}
   

