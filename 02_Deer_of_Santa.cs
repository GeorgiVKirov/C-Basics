using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deers_Of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysCount = double.Parse(Console.ReadLine());
            double foodLeft = double.Parse(Console.ReadLine());
            double foodDay1stDeer = double.Parse(Console.ReadLine());
            double foodDay2ndDeer = double.Parse(Console.ReadLine());
            double foodDay3rdDeer = double.Parse(Console.ReadLine());

            double totalFoodNeeded = foodDay1stDeer * daysCount + foodDay2ndDeer * daysCount + foodDay3rdDeer * daysCount;
            double foodDIff = Math.Floor(foodLeft - totalFoodNeeded);

            if (foodDIff >= 0)
            {
                Console.WriteLine($"{foodDIff} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(foodDIff)} more kilos of food are needed.");    
            }
        }
    }
}
