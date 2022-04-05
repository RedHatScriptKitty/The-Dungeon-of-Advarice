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
    }
}
   

