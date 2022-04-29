using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avarace_library
{
    public class Loot
    {
        public static string[] LFile()
        {
            Random rand = new Random();
            int unused = rand.Next(0, 20);
            string[] treasures = File.ReadAllLines(@"C:\Users\NoahC\source\repos\The-Dungeon-of-Advarice\txt adventure list\List treasures.txt");
            
            return (treasures);
        }
    }
}
