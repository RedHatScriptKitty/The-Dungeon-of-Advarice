using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Avarace_library
{
    public class playerlst
    {
        public static string[] User() 
        {
            string userName, userClass, userRace, userID;
            //string[] cls = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List Class ");
            //string[] race = File.ReadAllLines(@"C:\Users\NoahC\OneDrive\Desktop\txt adventure list\List Race ");
            using (StreamReader reader = File.OpenText(@"../../../txt adventure list\List Class"))
                return (userID);
        }
    }
}
