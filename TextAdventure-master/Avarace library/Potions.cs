using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avarace_library
{
    public class Potions
    {
        public static string[] PFile()
        {
            Random rand = new Random();
            int unused = rand.Next(0, 20);
            string[] potions = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List potions.txt");
            return (potions);
        }
    }
}
