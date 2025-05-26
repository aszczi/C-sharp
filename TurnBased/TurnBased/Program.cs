using System;

namespace TurnBased
{
    class TurnBased
    {
        static void Main(string[] args)
        {
            int playerHP = 40;
            int enemyHP = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while (playerHP > 0 && enemyHP > 0)
            {
                Console.WriteLine("\n--- Player Turn ---");
                Console.WriteLine("Player HP: " + playerHP + " | Enemy HP: " + enemyHP);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("Player attacks enemy and deals " + playerAttack + " damage!");
                }
                else if (choice == "h")
                {
                    playerHP += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Turn skipped.");
                }

                if (enemyHP > 0)
                {
                    Console.WriteLine("\n--- Enemy Turn ---");
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHP -= enemyAttack;
                        Console.WriteLine("Enemy attacks player and deals " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHP += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!");
                    }
                }
            }

            Console.WriteLine("\n=== GAME OVER ===");

            if (playerHP <= 0)
            {
                Console.WriteLine("Player has been defeated!");
            }
            else
            {
                Console.WriteLine("Enemy has been defeated! You won!");
            }
        }
    }
}
