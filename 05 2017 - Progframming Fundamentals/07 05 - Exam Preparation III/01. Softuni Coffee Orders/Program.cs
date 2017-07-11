using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < n; i++)
            {
                decimal ppc = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int qty = int.Parse(Console.ReadLine());

                var coffeePrice = ppc * qty * DateTime.DaysInMonth(date.Year, date.Month);
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
                total += coffeePrice;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
