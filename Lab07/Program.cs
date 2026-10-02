using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MonsterHP = 100;

            Console.WriteLine("Monster Defense: ");
            int monsterDefense = 0;
            int.TryParse(Console.ReadLine(), out monsterDefense);

            Console.WriteLine($"Slime HP: {MonsterHP}");
            Console.WriteLine($"Slime Defense: {monsterDefense}");
            Console.WriteLine();

            // Menu
            Console.WriteLine("Battle Menu:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Ice Magic");
            Console.WriteLine("4. Run");
            Console.WriteLine("5 Ice Spear");
            Console.WriteLine("Choose an action (1-5): ");

            int command = 0;
            int.TryParse(Console.ReadLine(), out command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("You attack the monster!");
                    break;
                case 2:
                    Console.WriteLine("You defend against the monster's attack!");
                    break;
                case 3:
                    Console.WriteLine("You cast an ice magic spell!");
                    break;
                case 4:
                    Console.WriteLine("You run away from the battle!");
                    break;
                case 5:
                    Console.WriteLine("You cast Ice Spear!");
                    break;
                default:
                    Console.WriteLine("Invalid command. Please choose a number between 1 and 5.");
                    break;
            }
            Console.WriteLine();

            int power = command switch
            {
                1 => 10, // Attack power
                2 => 5,  // Defense power
                3 => 15, // Ice Magic power
                4 => 0,  // Run power
                5 => 20, // Ice Spear power
                _ => 0   // Default power for invalid command
            };

            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage dealt to the monster: {damage}");

            string ratting = damage switch
            {
                int d when d >= 15 => "Excellent",
                int d when d >= 10 => "Good",
                int d when d >= 5 => "Average",
                int d => "Poor"
            };
            Console.WriteLine($"Rating: {ratting}");

            string monsterStatus;
            if (damage >= MonsterHP)
            {
                monsterStatus = "The monster is defeated!";
            }
            else
            {
                monsterStatus = $"The monster has {MonsterHP - damage} HP left.";
            }
            Console.WriteLine(monsterStatus);
            Console.WriteLine();

            Console.WriteLine("Really want to exit? (Y/N): ");
            string answer = Console.ReadLine();

            switch (answer.ToUpper())
            {
                case "Y":
                    Console.WriteLine("Exiting the game...");
                    break;
                case "N":
                    Console.WriteLine("Continuing the game...");
                    break;
                default:
                    Console.WriteLine("Invalid input. Exiting the game by default.");
                    break;
            }
        }
    }
}
