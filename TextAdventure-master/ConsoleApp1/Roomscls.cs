using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Roomscls
    {
        public static void tstroom()
        {
            List<string> names = new List<string>();
            StreamReader inputfile;
            inputfile = File.OpenText("List rooms.txt");
            //char delim = '_';
            //string nameValue = inputfile.ReadLine();
            //string[] tokens = nameValue.Split(delim);
            string[] token = inputfile.ReadLine().Split('_');
            //Console.WriteLine(tokens[1]);
            foreach (string name in token)
            {
                names.Add(name);
                Console.WriteLine(name);
                Console.WriteLine(token);

            }
            foreach (string name in token)
            {

                Console.WriteLine($"{name} ");


            }
        }
    }
}
