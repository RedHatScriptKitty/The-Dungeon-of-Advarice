using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avarace_library
{
    public class Mobs
    {
        public static string[] MFile()
        {
            Random rand = new Random();
            int unused = rand.Next(0, 20);
            string[] mobs = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List mobs.txt");
            return (mobs);
        }
    }
}
