using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===> BATTLE MAGE <===");
            Console.WriteLine("HERO VS. Monsters -- Fight CAlculator ");

            // User input of Hero stats

            Console.Write("Hero Health: ");
            bool isHeroHealth = int.TryParse(Console.ReadLine(), out int heroHealth);
            Console.Write("Hero Attack: ");
            bool isHeroAttack = int.TryParse(Console.ReadLine(), out int heroAttack);
            Console.Write("Hero Defense: ");
            bool isHeroDefense = int.TryParse(Console.ReadLine(), out int heroDefense);

            // User input of Monster stats

            Console.Write("Monster Health: ");
            bool isMonsterHealth = int.TryParse(Console.ReadLine(), out int monsterHealth);
            Console.Write("Monster Attack: ");
            bool isMonsterAttack = int.TryParse(Console.ReadLine(), out int monsterAttack);
            Console.Write("Monster Defense: ");
            bool isMonsterDefense = int.TryParse(Console.ReadLine(), out int monsterDefense);

            // Check if player input is valid

            bool allHeroValid = isHeroHealth && isHeroAttack && isHeroDefense;
            bool allMonsterValid = isMonsterHealth && isMonsterAttack && isMonsterDefense;
            Console.WriteLine($"stats Validation: HERO: {allHeroValid}, MONSTER: {allMonsterValid}");
            Console.WriteLine($" [HERO]    HP: {heroHealth}, ATK: {heroAttack}, DEF: {heroDefense}");
            Console.WriteLine($" [MONSTER] HP: {monsterHealth}, ATK: {monsterAttack}, DEF: {monsterDefense}");

            // คำนวน damage normal attack (Arthmetic + Math)
            int normalDamage = Math.Max(0, heroAttack - monsterDefense);
            Console.WriteLine($"Normal Attack deals {normalDamage} DMG");

            // คำนวน power attack
            int powerDamage = Math.Max(0, (heroAttack * 2) - monsterDefense);
            Console.WriteLine($"Power Attack deals {powerDamage} DMG");

            // คำนวน Monster Attack
            int monsterDamage = Math.Max(0, monsterAttack - heroDefense);
            Console.WriteLine($"Monster Counter Attack deals: {monsterDamage} DMG");

            // un Cri Chance
            Random random = new Random();
            int roll = random.Next(1, 101); // Random number between 1 and 100
            bool isCritical = roll <= 10; // 10% chance for critical hit
            int criDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage;
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCritical})");
            Console.WriteLine($"Normal Attack would deal Critical: {criDamage} DMG");
        





        }
    }
}