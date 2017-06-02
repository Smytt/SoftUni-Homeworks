using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var hall = "";
            var package = Console.ReadLine();
            double price = 0;

            if (people <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (people <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (people <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else hall = "No Hall";

            switch (package)
            {
                case "Normal": price = (price + 500) * 0.95; break;
                case "Gold": price = (price + 750) * 0.90; break;
                case "Platinum": price = (price + 1000) * 0.85; break;
            }

            if (hall == "No Hall") Console.WriteLine("We do not have an appropriate hall.");
            else
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {price/people:f2}$");
            }
        }
    }
}
