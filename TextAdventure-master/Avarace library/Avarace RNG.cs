using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avarace_library
{
   public class Avarace_RNG
    {

        int playerDamage, mobDamage;

        
        public static int AttackRNG()
        {
            
            Random rand = new Random();
            int damage = rand.Next(0, 20);
            return (damage);
            
        }
        public static void Damage()
        {
            int playerHp = 100;
            int mobHp = 100;
            while (playerHp > 0 && mobHp > 0)
            {
                Random rand = new Random();
                int playerDamage = rand.Next(0, 20);
                playerHp = playerDamage;
                int mobDamage = rand.Next(0, 20);
                mobHp = mobDamage;

            }           
        }
        public static int PlayerDamage()
        {
            int playerHp = 100;

            while (playerHp > 0)
            {
                Random rand = new Random();
                int playerDamage = rand.Next(0, 20);
                playerHp = playerHp - playerDamage;
                
                return playerHp;
            }
            return playerHp;
        }      
    }
}
