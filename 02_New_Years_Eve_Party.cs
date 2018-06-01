using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearEve
{
    class Program
    {
        static void Main(string[] args)
        {
            double guestsCount = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());

            double priceDinner = guestsCount * 20;
            double moneyDiff = moneyHave - priceDinner;

            double moneyFireworks = moneyDiff * 0.40;
            double moneyCharity = moneyDiff * 0.60;

            if (moneyDiff >= 0)
            {
                Console.WriteLine($"Yes! {moneyFireworks:F0} lv are for fireworks and {moneyCharity:F0} lv are for donation.");
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Abs(moneyDiff):F0} lv more.");
            }
        }
    }
}
