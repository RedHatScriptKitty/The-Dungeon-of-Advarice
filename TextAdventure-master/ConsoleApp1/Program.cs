﻿/**
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
        
        public static void Main(string[] args)
        {
            bool start = false;
            Console.WriteLine("Would you like to Begin?");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                
                case "yes": start = true; break;

            }
            while (start == true)
            {
                menu.TmpMenu();
                
            }

        }
    }
}
