using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string studyingForm1 = Console.ReadLine().ToLower();
            int students1 = int.Parse(Console.ReadLine());
            string studyingForm2 = Console.ReadLine().ToLower();
            int students2 = int.Parse(Console.ReadLine());
            string studyingForm3 = Console.ReadLine().ToLower();
            int students3 = int.Parse(Console.ReadLine());

            int sumOnline = 0;
            int sumOnsite = 0;
            int sumTotal = 0;

            switch (studyingForm1)
            {
                case "online":
                    sumOnline += students1;
                    break;
                case "onsite":
                    sumOnsite += students1;
                    break;
            }
            switch (studyingForm2)
            {
                case "online":
                    sumOnline += students2;
                    break;
                case "onsite":
                    sumOnsite += students2;
                    break;

            }
            switch (studyingForm3)
            {
                case "online":
                    sumOnline += students3;
                    break;
                case "onsite":
                    sumOnsite += students3;
                    break;
            }
            sumTotal = sumOnline + sumOnsite;

            if (sumOnsite > 600)
            {
                sumOnline += sumOnsite - 600;
                sumOnsite = 600;
            }
            Console.WriteLine($"Online students: {sumOnline}");
            Console.WriteLine($"Onsite students: {sumOnsite}");
            Console.WriteLine($"Total students: {sumTotal}");

        }
    }
}

