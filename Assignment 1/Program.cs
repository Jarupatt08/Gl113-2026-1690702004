using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.const (Pascalcase) - ชื่อยานพหานะ/ระบบ
            const string VesselName = "USS Enterprise";

            // 2. var (camelcase) - ใช้กับ string เเละ char รวมกัน 2 ตัว
            var pilotCallsign = "Captain Kirk"; //ใช้ var บน string
            var shipClass = 'A'; //ใช้ var บน char

            // 3. ชนิดข้อมูลพื้นฐาน 6 เเบบ
            // string : pilotCallsign
            // char : shipClass
            // int : warplevel
            // float : shieldPerrcentage
            // double : fuelCellLevel
            // bool : hyperdriveReady
            int warplevel = 8;
            float shieldPerrcentage = 0.85f;
            double fuelCellLevel = 67.8;
            bool hyperdriveReady = true;

            // Display Output - เปลี่ยนเป็นธีม Dashboard ยานอวกาศ
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|        VESSEL DASHBOARD      |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine($"Vessel Name: {VesselName}");
            Console.WriteLine($"Pilot Callsign: {pilotCallsign}");
            Console.WriteLine($"Ship Class: {shipClass}");
            Console.WriteLine($"Warp Level: {warplevel}");
            Console.WriteLine($"Shield Percentage: {shieldPerrcentage:P2}");
            Console.WriteLine($"Fuel Cell Level: {fuelCellLevel:F1}");
            Console.WriteLine($"Hyperdrive Ready: {hyperdriveReady}");
            Console.WriteLine($"+------------------------------+");
            Console.WriteLine();

            // 4. Implicit Converslion
            double warpLevelDouble = warplevel;
            Console.WriteLine($"[LOG] Warp Level (Implicit Double): {warpLevelDouble}");

            // 5. Explcit Cast vs Convert.Toint32()
            // (int) จะทำการตัดเศษทิ้งเสมอ
            int fuelRounded = Convert.ToInt32(fuelCellLevel);

            Console.WriteLine($"[CAST] Fuel Level (Truncated): {fuelRounded}");
            Console.WriteLine($"[CONVERT] Fuel Level (Rounded): {fuelCellLevel}");
            Console.WriteLine($"+------------------------------+");
        }
    }
}
