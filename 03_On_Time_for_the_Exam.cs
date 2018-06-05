using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTIme2
{
    class Program
    {
        static void Main(string[] args)
        {
            int examtHour = int.Parse(Console.ReadLine());
            int examtMinutes = int.Parse(Console.ReadLine());
            int arrivelHour = int.Parse(Console.ReadLine());
            int arrivelMinutes = int.Parse(Console.ReadLine());

            int examTime = examtHour * 60 + examtMinutes;
            int arrivalTime = arrivelHour * 60 + arrivelMinutes;

            int difference = examTime - arrivalTime;

            if (difference >= 0 &&  difference <=30)
            {
                Console.WriteLine("On Time");

                if (difference != 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");

                if (difference >= 60)
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;

                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine( $"{difference} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");

                difference = Math.Abs(difference);
                if (difference >= 60)
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;

                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
            }
        }

    }
}
