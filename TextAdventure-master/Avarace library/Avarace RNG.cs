using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avarace_library
{
   public static class Avarace_RNG
    {
        
        
        public static int AttackRNG()
        {
            
            Random rand = new Random();
            int damage = rand.Next(0, 20);
            return (damage);
            
        }
        public static void Damage()
        {
            bool test = true;
            //int DamageHistory;
            //int Dp = 0;
            while (test == true)
            {
                int DamageHistory;
                int Dp = 0;
                if (Dp == 0)
                {
                    Dp = Dp + AttackRNG();
                    DamageHistory = Dp;
                }
                
            }
            
            
        }
        public static int Health()
        {
            int health = 100;
            int damage = AttackRNG();
            health = health - damage;
            return health;
            
            //Random rand = new Random();
            //int damage = rand.Next(0, 20);
            //Console.WriteLine(damage+"pts of Damage");
        }
        public static void Test()
        { Console.WriteLine("test"); }
    }
}
