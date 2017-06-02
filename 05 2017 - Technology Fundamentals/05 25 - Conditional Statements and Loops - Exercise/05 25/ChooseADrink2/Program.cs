using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete": Console.WriteLine($"The {profession} has to pay {0.7*quantity:f2}."); break;
                case "Businessman":
                case "Businesswoman": Console.WriteLine($"The {profession} has to pay {quantity:f2}."); break;
                case "SoftUni Student": Console.WriteLine($"The {profession} has to pay {1.7 * quantity:f2}."); break;
                default: Console.WriteLine($"The {profession} has to pay {1.2 * quantity:f2}."); break;
            }
        }
    }
}
