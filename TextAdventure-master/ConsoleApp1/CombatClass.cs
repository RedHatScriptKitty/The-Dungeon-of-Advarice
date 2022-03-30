using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CombatClass
    {
        public static int Damage()
        {
            int playerHp = 100;
            int mobHp = 100;
            int died = 1;
            while (mobHp > 0 && playerHp > 0)
            {

                if (mobHp > 0)
                {
                    Random rand = new Random();
                    int playerDamage = rand.Next(0, 20);
                    mobHp = mobHp - playerDamage;
                    if (mobHp > 0)
                    { 
                    Console.WriteLine("Player Damage " + playerDamage);
                    Console.WriteLine($"Mob HP ({mobHp}) ");
                    }
                    else
                    {
                        Console.WriteLine("Mob has been slain");
                    }
                    

                }
                if (playerHp <= 0)
                    {
                        Console.WriteLine("You Died");

                    }

                if (playerHp > 0 && mobHp > 0)
                {
                    Random rand = new Random();
                    int mobDamage = rand.Next(0, 20);

                    playerHp = playerHp - mobDamage;
                    if (playerHp > 0) 
                    {
                    Console.WriteLine("Mob Damage " + mobDamage);
                    Console.WriteLine($"Player HP ({playerHp}) ");
                    }
                    
                }
                
            }
            if (playerHp <= 0)
            {
                Console.WriteLine("You Died");
                died = 0;

            }
            return died;
        }
    }
}
