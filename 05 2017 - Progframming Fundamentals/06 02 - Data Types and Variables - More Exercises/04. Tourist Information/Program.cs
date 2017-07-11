using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperial = Console.ReadLine();
            decimal value = decimal.Parse(Console.ReadLine());
            decimal convertedValue = 0;
            string metric = "";

            switch (imperial)
            {
                case "miles":
                    convertedValue = value * 1.6m;
                    metric = "kilometers";
                    break;
                case "inches":
                    convertedValue = value * 2.54m;
                    metric = "centimeters";
                    break;
                case "feet":
                    convertedValue = value * 30;
                    metric = "centimeters";
                    break;
                case "yards":
                    convertedValue = value * 0.91m;
                    metric = "meters";
                    break;
                case "gallons":
                    convertedValue = value * 3.8m;
                    metric = "liters";
                    break;
            }
            Console.WriteLine($"{value} {imperial} = {convertedValue:f2} {metric}");
        }
    }
}
