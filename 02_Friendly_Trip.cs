using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double fuelPer100 = double.Parse(Console.ReadLine());
            double fuelPrice = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());

            double fuelUsed = distance * (fuelPer100 / 100);
            double moneySpentForFuel = fuelUsed * fuelPrice;

            double moneyDiff = moneyHave - moneySpentForFuel;
            double moneyForEach = moneyHave / 5;

            if (moneyDiff >=0)
            {
                Console.WriteLine($"You can take a trip. {moneyDiff:f2} money left.");
            }

            else
            {
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {moneyForEach:f2} money.");
            }
        }
    }
}
        
