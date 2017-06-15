using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = new string(numbers[i].Reverse().ToArray());
                sum += int.Parse(numbers[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
