using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourDeparts = int.Parse(Console.ReadLine());
            int minutesDeparts = int.Parse(Console.ReadLine());
            int flightLength = int.Parse(Console.ReadLine());

            int flightTdepartsInMinutes = hourDeparts * 60 + minutesDeparts;
            int timeOfArrivel = flightTdepartsInMinutes + flightLength;
            int hourOfArr = timeOfArrivel / 60;
            int minutesOfArr = timeOfArrivel % 60;

            if (hourOfArr >=23)
            {
                hourOfArr -= 24;
            }

            Console.WriteLine($"{hourOfArr}h {minutesOfArr}m");

        }
    }
}
