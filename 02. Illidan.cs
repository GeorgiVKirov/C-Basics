using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int playersCount = int.Parse(Console.ReadLine());
            int powerPerPlayesr = int.Parse(Console.ReadLine());
            int powerIllidan = int.Parse(Console.ReadLine());

            int powerPlayers = powerPerPlayesr * playersCount;
            int powerDIff = powerIllidan - powerPlayers;

            if (powerPlayers >= powerIllidan)
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {Math.Abs(powerDIff)} points.");
            }
            else
            {
                Console.WriteLine($"You are not prepared! You need {powerDIff} more points.");
            }
        }
    }
}
