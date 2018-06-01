using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_On_The_Wall
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthHole = int.Parse(Console.ReadLine());
            int lengthHole = int.Parse(Console.ReadLine());
            int pictureSide = int.Parse(Console.ReadLine());
            int countPictures = int.Parse(Console.ReadLine());

            int areaHole = widthHole * lengthHole;
            int areaPictures = (pictureSide * pictureSide) * countPictures;
            int areaDiff = areaHole - areaPictures;

            if (areaHole < areaPictures)
            {
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {Math.Abs(areaDiff)} bigger than hole area.");
            }

            else
            {
                Console.WriteLine($"The pictures fit in the hole. Hole area is {areaDiff} bigger than pictures area.");
            }
        }
    }
}
