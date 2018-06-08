using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyHave = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double priceCard = 0;

            if (gender == "m")
            {
                switch (sport)
                {
                    case "Gym":
                        priceCard = 42;
                        break;
                    case "Boxing":
                        priceCard = 41;
                        break;
                    case "Yoga":
                        priceCard = 45;
                        break;
                    case "Zumba":
                        priceCard = 34;
                        break;
                    case "Dances":
                        priceCard = 51;
                        break;
                    case "Pilates":
                        priceCard = 39;
                        break;
                }
            }
            else if (gender == "f")
            {
                switch (sport)
                {
                    case "Gym":
                        priceCard = 35;
                        break;
                    case "Boxing":
                        priceCard = 37;
                        break;
                    case "Yoga":
                        priceCard = 42;
                        break;
                    case "Zumba":
                        priceCard = 31;
                        break;
                    case "Dances":
                        priceCard = 53;
                        break;
                    case "Pilates":
                        priceCard = 37;
                        break;
                }
            }
            if (age <= 19)
            {
                priceCard -= priceCard * 0.20;
            }
            double moneyDIff = moneyHave - priceCard;

            if (moneyDIff >= 0)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${Math.Abs(moneyDIff):f2} more.");
            }

        }
    }
}
