using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (CondenseToNumber(array).Length > 0)
            {
                array = CondenseToNumber(array);
            }

            Console.WriteLine(String.Join(" ", array));
        }

        static int[] CondenseToNumber(int[] array)
        {
            int[] condensed = new int[array.Length - 1];
            for (int i = 0; i < array.Length-1; i++)
            {
                condensed[i] = array[i] + array[i + 1];
            }
            return condensed;
        }
    }
}
