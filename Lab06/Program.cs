using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1.ตรวจสอบชีวิต
            Console.WriteLine("1. ตรวจสอบชีวิต\n");
            int lives = 0;
            if (lives <= 0)
            {
                Console.WriteLine("Game Over");
            }
            Console.WriteLine("Continue Running\n");

            // 2.ตรวจสอบเงินเเละราคา
            Console.WriteLine("2. ตรวจสอบเงินเเละราคา\n");
            int money = 100;
            int price = 50;
            if (money >= price)
            {
                Console.WriteLine("คุณมีเงินพอสำหรับซื้อสินค้า");
            }
            else
            {
                Console.WriteLine("คุณมีเงินไม่พอสำหรับซื้อสินค้า");
            }
            Console.WriteLine();

            // 3.จัดอันดับคะแนน
            Console.WriteLine("3. จัดอันดับคะแนน\n");
            int score = 85;
            if (score >= 80)
            {
                Console.WriteLine("คุณได้เกรด A");
            }
            else if (score >= 70)
            {
                Console.WriteLine("คุณได้เกรด B");
            }
            else
            {
                Console.WriteLine("คุณได้เกรด C");
            }
            Console.WriteLine();

            // 4.ตรวจสอบ Level
            Console.WriteLine("4. ตรวจสอบ Level\n");
            Console.WriteLine("your level (1-99): ");
            bool ok = int.TryParse(Console.ReadLine(), out int level);
            if (ok || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid level, please try again.");
            }
            else
            {
                if (level >= 1 && level <= 10)
                {
                    Console.WriteLine("คุณอยู่ในระดับ Beginner");
                }
                else if (level >= 11 && level <= 20)
                {
                    Console.WriteLine("คุณอยู่ในระดับ Intermediate");
                }
                else if (level >= 21 && level <= 30)
                {
                    Console.WriteLine("คุณอยู่ในระดับ Advanced");
                }
                else
                {
                    Console.WriteLine("คุณอยู่ในระดับ Expert");
                }
                Console.WriteLine();

                // 5.ผจญภัยของ Brian
                Console.WriteLine("5. ผจญภัยของ Brian\n");
                int heroHealth = 100;
                int monsterHealth = 50;
                int attackDamage = 20;

                Console.WriteLine("Adventure of Brian");
                Console.WriteLine("Monster Encouter 1");
                Console.WriteLine("Action A: Attack");
                Console.WriteLine("Action B: Run Away\n");

                Console.WriteLine("Choose your action");
                bool inputOk = int.TryParse(Console.ReadLine(), out int choice);

                if (inputOk || (choice != 'a' && choice != 'A' && choice != 'b' && choice != 'B'))

                { }
                Console.WriteLine("Invalid input, Please choose netween A or B");
                {
                    if (choice == 'a' || choice == 'A')
                    {
                        monsterHealth -= attackDamage;
                        if (monsterHealth <= 0)
                        {
                            Console.WriteLine($"Player attack monster with {attackDamage} points, Monster defeated!");
                        }
                        else
                        { }
                        Console.WriteLine($"Player attack monster with {attackDamage} point, Monster HP has {monsterHealth} HP left.");
                    }
                    else if (choice == 'b' || choice == 'B')
                    {
                        heroHealth -= 30;
                        Console.WriteLine($"Player run away from monster, but took {30} damage. Hero HP has {heroHealth} HP left.");
                    }
                    else
                    {
                        Console.WriteLine("Timeout: You ran out of time!");
                    }
                }
            }
        }
    }
}


















                    
                
            
        
   









































