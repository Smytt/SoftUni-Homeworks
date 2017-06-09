using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(MiddleElements(array));
        }

        static string MiddleElements(int[] array)
        {
            if (array.Length == 1) return $"{{ {array[0]} }}";
            if (array.Length % 2 == 0)
                return $"{{ {array[array.Length/2 - 1]}, {array[array.Length / 2]} }}";
            return $"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]}, {array[array.Length / 2 + 1]} }}";
        }
    }
}
