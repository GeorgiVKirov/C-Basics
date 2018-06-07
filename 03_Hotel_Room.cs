using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            double daysStay = double.Parse(Console.ReadLine());

            double pricePerDayStudio = 0;
            switch (month)
            {
                case "may":
                case "october":
                    pricePerDayStudio = 50;
                    break;
                case "june":
                case "september":
                    pricePerDayStudio = 75.20;
                    break;
                case "july":
                case "august":
                    pricePerDayStudio = 76;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            double pricePerDayApart = 0;
            switch (month)
            {
                case "may":
                case "october":
                    pricePerDayApart = 65;
                    break;
                case "june":
                case "september":
                    pricePerDayApart = 68.70;
                    break;
                case "july":
                case "august":
                    pricePerDayApart = 77;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            double finalPriceStudio = pricePerDayStudio * daysStay;

            double finalPriceApart = pricePerDayApart * daysStay;

            if (daysStay > 7 && daysStay <=14 && (month == "may" || month == "october"))
            {
                finalPriceStudio = finalPriceStudio * 0.95;
            }
            else if (daysStay > 14 && (month == "may" || month == "october"))
            {
                finalPriceStudio = finalPriceStudio * 0.70;
                finalPriceApart = finalPriceApart * 0.90;
            }
            else if (daysStay > 14 && (month == "june" || month == "september"))
            {
                finalPriceStudio = finalPriceStudio * 0.80;
                finalPriceApart = finalPriceApart * 0.90;
            }
            else if (daysStay > 14 && (month == "july" || month == "august"))
            {
                finalPriceApart = finalPriceApart * 0.90;
            }

            Console.WriteLine($"Apartment: {finalPriceApart:f2} lv.");
            Console.WriteLine($"Studio: {finalPriceStudio:f2} lv.");
        }
    }
}
