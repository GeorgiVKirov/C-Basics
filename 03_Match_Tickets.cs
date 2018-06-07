using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIckets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine().ToLower();
            double peopleCount = double.Parse(Console.ReadLine());

            double ticketPrice = 0;
            if (ticketCategory == "vip")
            {
               ticketPrice = 499.99;
            }
            else if (ticketCategory == "normal")
            {
                ticketPrice = 249.99;
            }


            double moneyTransport = 0;
            if (peopleCount > 0 && peopleCount <= 4) 
            {
                moneyTransport = budget * 0.75;
            }
            else if (peopleCount > 4 && peopleCount <= 9)
            {
                moneyTransport = budget * 0.60;
            }
            else if (peopleCount > 9 && peopleCount <= 24)
            {
                moneyTransport = budget * 0.50;
            }
            else if (peopleCount > 24 && peopleCount <= 49)
            {
                moneyTransport = budget * 0.40;
            }
            else if (peopleCount >= 50)
            {
                moneyTransport = budget * 0.25;
            }


            budget = budget - (ticketPrice * peopleCount + moneyTransport);

            if (budget >= 0)
            {
                Console.WriteLine($"Yes! You have {budget:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget):f2} leva.");
            }
       
        }
    }
}
