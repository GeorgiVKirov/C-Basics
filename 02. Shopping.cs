using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyHave = double.Parse(Console.ReadLine());
            double chokoCount = double.Parse(Console.ReadLine());
            double litersMilk = double.Parse(Console.ReadLine());

            double tangerines = Math.Floor(chokoCount * 0.65);

            double moneyMilk = litersMilk * 2.70;
            double moneyChoko = chokoCount * 0.65;
            double moneyTangerines = tangerines * 0.20;

            double moneySpent = moneyMilk + moneyChoko + moneyTangerines;

            double moneyDiff = moneyHave - moneySpent;

            if (moneyDiff >= 0)
            {
                Console.WriteLine($"You got this, {moneyDiff:F2} money left!");
            }

            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(moneyDiff):F2} more!");
            }
        }
    }
}
