/*
 * Student ID : 1690702004
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // ประกาศตัวเเปร 6 ตัว
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine();
            // คำนวนค่าเปอร์เซ็นต์
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            // ลดค่า Hp ลง 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            // ตัวละครที่ 1 : นักรบอัศวิน
            string p1Name = "Gepard";
            int p1Hp = 500;
            float p1Armor = 75.5f;
            char p1Rank = 'A';
            bool p1IsAlive = true;

            Console.WriteLine($"Name: {p1Name}");
            Console.WriteLine($"HP: {p1Hp}");
            Console.WriteLine($"Armor: {p1Armor}");
            Console.WriteLine($"Rank: {p1Rank}");
            Console.WriteLine($"Is Alive: {p1IsAlive}");

            // ตัวละครที่ 2 : นักเวทย์
            string p2Name = "Luna";
            int p2Hp = 300;
            float p2Mana = 200.0f;
            char p2Rank = 'B';
            bool p2IsAlive = true;

            Console.WriteLine($"Name: {p2Name}");
            Console.WriteLine($"HP: {p2Hp}");
            Console.WriteLine($"Mana: {p2Mana}");
            Console.WriteLine($"Rank: {p2Rank}");
            Console.WriteLine($"Is Alive: {p2IsAlive}");
            // ตัวละครที่ 3 : นักธนู
            string p3Name = "Aragorn";
            int p3Hp = 400;
            float p3BowPower = 80.0f;
            char p3Rank = 'A';
            bool p3IsAlive = true;

            Console.WriteLine($"Name: {p3Name}");
            Console.WriteLine($"HP: {p3Hp}");
            Console.WriteLine($"Bow Power: {p3BowPower}");
            Console.WriteLine($"Rank: {p3Rank}");
            Console.WriteLine($"Is Alive: {p3IsAlive}");

            // ตัวละครที่ 4 : นักฆ่า
            string p4Name = "Shadow";
            int p4Hp = 350;
            float p4DaggerPower = 90.0f;
            char p4Rank = 'B';
            bool p4IsAlive = true;

            Console.WriteLine($"Name: {p4Name}");
            Console.WriteLine($"HP: {p4Hp}");
            Console.WriteLine($"Dagger Power: {p4DaggerPower}");
            Console.WriteLine($"Rank: {p4Rank}");
            Console.WriteLine($"Is Alive: {p4IsAlive}");
        }


    }
}
     