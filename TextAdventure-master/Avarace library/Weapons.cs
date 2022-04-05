using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avarace_library
{
    public class Weapons
    {
        public static string[] WFile()
        {
            Random rand = new Random();
            int unused = rand.Next(0, 20);
            string[] weapons = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List weapons.txt");
            return (weapons);

        }
}
