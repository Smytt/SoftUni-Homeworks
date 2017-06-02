using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    counter++;
                    sum += i * j * 3;
                    if (sum >= max)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {max}");
                        break;
                    }
                }
                if (sum >= max)
                {
                    break;
                }
            }

            if (sum < max)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
