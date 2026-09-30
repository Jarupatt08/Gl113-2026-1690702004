using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ค่าคงที่ - Pascalcase
            const double SmeltRate = 0.5;
            const double SalvageRate = 0.2;
            const double MaxBatch = 1000;

            Console.WriteLine("----------------------------");
            Console.WriteLine("--- Welcome to the Forge ---");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"=> Iron Smelting {SmeltRate:F2 / SalvageRate:F2}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'A' for breakdown (Ingot -> Ore)");

            Console.WriteLine("=> Choose Menu: ");
            string menuInput = Console.ReadLine();
            char menuChar = '\0';
            bool menuOK = false;

            if (char.TryParse(menuInput, out menuChar))
            {
                char m = char.ToLower(menuChar);
                if (m == 's' || m == 'a')
                {
                    menuOK = true;
                }
            }

            if (!menuOK)
            {
                Console.WriteLine("error: menu");
                return;

            }
            Console.WriteLine("=> How much would you like:");
            string amountInput = Console.ReadLine();
            double amount = 0;
            bool amountOk = false;

            if (double.TryParse(amountInput, out amount))
            {
                if (amount > 0 && amount <= MaxBatch);

            }
            amountOk = true;
            {
                if (amount <= 0) ;
            }
            Console.WriteLine("error: amount");
            {
                if (!amountOk) ;
            }
            return;

            char menu = char.ToLower(menuChar);
            if (menu == 's') ;
            {
                double result = amount * SmeltRate;
                Console.WriteLine($"=> {amount:F2} Iron Ore = {result:F2} iron Ingot");
            }

            {
                if (menu == 'a') ;
            }
            {
                double result = amount / SalvageRate;
                Console.WriteLine($"=> {amount:F2} Iron Ingot = {result:F2} Iron Ore ");
            }
            {
                Console.WriteLine("error:menu");
            }
        }
    }
}
