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
        public static string[] tstroom()
        {
            List<string> names = new List<string>();
            StreamReader inputfile;
            inputfile = File.OpenText("List rooms");
            char delim = '-';
            string nameValue = inputfile.ReadLine();
            string[] tokens = nameValue.Split(delim);

                foreach (string name in tokens)
                {
                    //names.Add(name);
                    Console.WriteLine(name);

                }
            return (tokens);
        }
    }
}
