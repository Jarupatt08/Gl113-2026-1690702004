using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // output เเสดงตัวเเปร
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Boss Name: {bossName}\nRank {rank}\nLevel: {level} / {MaxLevel}\nHP : {currentHp} / {maxHp}\nAttack Power: {attackPower}\nCritical Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            // ทำ Implicit int -> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpAsDouble = currentHp; // Int -> Double เเปลงค่าเเบบไม่ Cast ใส่ค่าได้เลย
            Console.WriteLine($"Current HP as Double: {currentHpAsDouble}");

            // ทำ Implicit หลังการคำนวนเปอร์เซ็นต์ ที่ผลลัพธ์ทศนิยม
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = currentHpAsDouble * 100 / maxHp; // int หาร int จากนั้นเเปลงผลลัพธ์เป็น double เเบบ Implicit
            Console.WriteLine($"HP percent: (exct) : {hpPercent}%");

            // ทำ Explicit โดยการ casting (float) Attackpower -> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackPowerAsInt = (int)attackPower; // เเปลงเป็นข้อมูลโดยการ Cast Syntax
            Console.WriteLine($"Attack power (int cast): {attackPowerAsInt}");

            Console.WriteLine($"\n---- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);

            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
            Console.WriteLine($"\n---- Cast vs Convert: Crit Multiplier -----");




        }
    }
}
