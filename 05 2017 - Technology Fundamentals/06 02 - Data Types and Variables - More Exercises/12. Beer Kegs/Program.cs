using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string biggestModel = "";

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double volume = Math.PI * r * r * h;

                if (i == 1)
                {
                    biggestModel = model;
                    biggestVolume = volume;
                }

                else
                {
                    if (volume > biggestVolume)
                    {
                        biggestVolume = volume;
                        biggestModel = model;
                    }
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
