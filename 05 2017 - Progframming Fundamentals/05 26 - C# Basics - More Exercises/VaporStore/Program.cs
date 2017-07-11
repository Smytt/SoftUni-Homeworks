using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            double price = 0;
            double spent = 0;
            var nogame = false;

            var name = Console.ReadLine();

            while (name != "Game Time")
            {
                switch (name)
                {
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    default: Console.WriteLine("Not Found"); break;
                }
                
                if (budget < price)
                {
                    Console.WriteLine("Too Expensive");
                }

                else if (price!=0)
                {
                    spent += price;
                    budget -= price;
                    Console.WriteLine($"Bought {name}");
                    if (budget == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }                

                price = 0;
                name = Console.ReadLine();
            }

            if ( name == "Game Time" )
            {
                Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${budget:F2}");
            }
        }
    }
}
