using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CombatClass
    {
        public static void Damage()
        {
            int playerHp = 100;
            int mobHp = 100;
            while (mobHp > 0)
            {
                if (mobHp > 0)
                {
                    Random rand = new Random();
                    int mobDamage = rand.Next(0, 20);
                    mobHp = mobHp - playerDamage;
                    Console.WriteLine("Mob Damage " + mobDamage);
                    Console.WriteLine($"Mob HP ({mobHp}) ");
                    

                }
                if (playerHp > 0)
                {
                    Random rand = new Random();
                    int playerDamage = rand.Next(0, 20);
                    
                    playerHp = playerHp - mobDamage;
                    Console.WriteLine("Player Damage " + playerDamage);
                    Console.WriteLine($"Player HP ({playerHp}) ");
                    if (playerHp == 0)
                    {
                        Console.WriteLine("You Died");

                    }
                }
                
            }
        }
    }
}
