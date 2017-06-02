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
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioRoom = 0;
            double doubleRoom = 0;
            double suiteRoom = 0;

            if (month == "May" || month == "October")
            {
                studioRoom = 50;
                doubleRoom = 65;
                suiteRoom = 75;
                if (nights > 7)
                {
                    studioRoom *= 0.95;
                    if (month == "October")
                    {
                        studioRoom = studioRoom * (nights - 1) / nights;
                    }
                }

            }
            else if (month == "June" || month == "September")
            {
                studioRoom = 60;
                doubleRoom = 72;
                suiteRoom = 82;
                if (nights > 14)
                {
                    doubleRoom *= 0.90;
                }
                if (month == "September" && nights > 7) 
                {
                    studioRoom = studioRoom * (nights - 1) / nights;
                }
            }
            else
            {
                studioRoom = 68;
                doubleRoom = 77;
                suiteRoom = 89;
                if (nights > 14)
                {
                    suiteRoom *= 0.85;
                }
            }

            Console.WriteLine($"Studio: {studioRoom*nights:f2} lv.");
            Console.WriteLine($"Double: {doubleRoom * nights:f2} lv.");
            Console.WriteLine($"Suite: {suiteRoom * nights:f2} lv.");
        }
    }
}
