/**
* 2/17/22
* CSC 153
* Noah Kolb
* Text adventure
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avarace_library;


namespace ConsoleApp1
{
    class Program
    {
        
        public static void Main(/*string[] args*/)
        {
            List<string> names = new List<string>();
            StreamReader inputfile;
            inputfile = File.OpenText("List rooms.txt");
            //char delim = '_';
            //string nameValue = inputfile.ReadLine();
            //string[] tokens = nameValue.Split(delim);
            string[] tokens = inputfile.ReadLine().Split('_');
            //Console.WriteLine(tokens[1]);
            foreach (string name in tokens)
            {
                names.Add(name);
                //Console.WriteLine(name);

            }
            foreach (string name in tokens)
            {
                
                Console.Write($"{name}");

            }


            bool start = false;
            Console.WriteLine("Would you like to Begin?");
            //Roomscls.tstroom();
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                
                case "yes": start = true; break;
                case "no": start = false; break;    
                default: Console.WriteLine(input + " is Not an Option please Enter Yes or No"); Console.WriteLine(""); Program.Main();break;
                
                
            }
            while (start == true)
            {
                menu.TmpMenu();
                
            }

        }
    }
}
