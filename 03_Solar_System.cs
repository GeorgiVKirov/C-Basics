using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string planet = Console.ReadLine().ToLower();
            double daysOnPlanet = double.Parse(Console.ReadLine());

            double distance = 0;
            double maxDaysOnPlanet = 0;

            switch (planet)
            {
                case "mercury":
                    distance = 0.61;
                    maxDaysOnPlanet = 7;
                    break;
                case "venus":
                    distance = 0.28;
                    maxDaysOnPlanet = 14;
                    break;
                case "mars":
                    distance = 0.52;
                    maxDaysOnPlanet = 20;
                    break;
                case "jupiter":
                    distance = 4.2;
                    maxDaysOnPlanet = 5;
                    break;
                case "saturn":
                    distance = 8.52;
                    maxDaysOnPlanet = 3;
                    break;
                case "uranus":
                    distance = 18.21;
                    maxDaysOnPlanet = 3;
                    break;
                case "neptune":
                    distance = 29.09;
                    maxDaysOnPlanet = 2;
                    break;
            }
            if (planet != "mercury" && planet != "venus" && planet != "mars" && planet != "jupiter" && planet != "saturn" && planet != "uranus" && planet != "neptune")
            {
                Console.WriteLine("Invalid planet name!");
            }

            double distanceTotal = distance * 2;
            double distanceInDays = (distance * 226) * 2 + daysOnPlanet;

            if (planet == "mercury" && daysOnPlanet <= maxDaysOnPlanet)
            {
                Console.WriteLine($"Distance: {distanceTotal:f2}");
                Console.WriteLine($"Total number of days: {distanceInDays:f2}");

            }
            else if (planet == "mercury" && daysOnPlanet > maxDaysOnPlanet)
            {
                Console.WriteLine("Invalid number of days!");
            }
            else if (planet == "venus" && daysOnPlanet <= maxDaysOnPlanet)
            {
                Console.WriteLine($"Distance: {distanceTotal:f2}");
                Console.WriteLine($"Total number of days: {distanceInDays:f2}");
            
            }
            else if (planet == "venus" && daysOnPlanet > maxDaysOnPlanet)
            {
                Console.WriteLine("Invalid number of days!");
            }
            else if (planet == "mars" && daysOnPlanet <= maxDaysOnPlanet)
            {
                Console.WriteLine($"Distance: {distanceTotal:f2}");
                Console.WriteLine($"Total number of days: {distanceInDays:f2}");
            }
            else if (planet == "mars" && daysOnPlanet > maxDaysOnPlanet)
            {
                Console.WriteLine("Invalid number of days!");
            }
            else if (planet == "jupiter" && daysOnPlanet <= maxDaysOnPlanet)
            {
                Console.WriteLine($"Distance: {distanceTotal:f2}");
                Console.WriteLine($"Total number of days: {distanceInDays:f2}");
            }
            else if (planet == "jupiter" && daysOnPlanet > maxDaysOnPlanet)
            {
                Console.WriteLine("Invalid number of days!");
            }
            else if (planet == "saturn" && daysOnPlanet <= maxDaysOnPlanet)
            {
                Console.WriteLine($"Distance: {distanceTotal:f2}");
                Console.WriteLine($"Total number of days: {distanceInDays:f2}");
            }
            else if (planet == "saturn" && daysOnPlanet > maxDaysOnPlanet)
            {
                Console.WriteLine("Invalid number of days!");
            }
            else if (planet == "uranus" && daysOnPlanet <= maxDaysOnPlanet)
            {
                Console.WriteLine($"Distance: {distanceTotal:f2}");
                Console.WriteLine($"Total number of days: {distanceInDays:f2}");
            }
            else if (planet == "uranus" && daysOnPlanet > maxDaysOnPlanet)
            {
                Console.WriteLine("Invalid number of days!");
            }
            else if (planet == "neptune" && daysOnPlanet <= maxDaysOnPlanet)
            {
                Console.WriteLine($"Distance: {distanceTotal:f2}");
                Console.WriteLine($"Total number of days: {distanceInDays:f2}");
            }
            else if (planet == "neptune" && daysOnPlanet > maxDaysOnPlanet)
            {
                Console.WriteLine("Invalid number of days!");
            }
        }
    }
}
