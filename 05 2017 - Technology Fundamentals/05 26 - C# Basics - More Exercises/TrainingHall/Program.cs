using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            double price = 0.0;

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double currentPrice = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                string plural = "";
                price += count * currentPrice;

                if (count > 1) { plural = "s"; }

                Console.WriteLine($"Adding {count} {name}{plural} to cart.");

            }
            Console.WriteLine($"Subtotal: ${price:f2}");

            if (price > budget)
            {
                Console.WriteLine($"Not enough. We need ${price-budget:f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${budget-price:f2}");
            }

        }
    }
}
