using System;

namespace Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            int respondentsCount = int.Parse(Console.ReadLine());
            int firstPlaceResp = int.Parse(Console.ReadLine());

            double secondPlaceResp = firstPlaceResp * 0.8;
            double thirdPlaceResp = secondPlaceResp * 0.9;

            double halfvotes = respondentsCount / 2;

            double countDiff = Math.Floor(firstPlaceResp + secondPlaceResp + thirdPlaceResp - halfvotes);

            if (countDiff >= 0)
            {
                Console.WriteLine($"First three languages have {countDiff} votes more");
            }
            else
            {
                Console.WriteLine($"First three languages have {Math.Abs(countDiff)} votes less of half votes");
            }
        }
    }
}
