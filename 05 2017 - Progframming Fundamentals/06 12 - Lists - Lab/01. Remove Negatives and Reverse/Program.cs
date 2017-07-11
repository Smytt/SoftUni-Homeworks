using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> filtered = new List<int>();

            foreach (var num in numbers)
            {
                if(num >= 0)
                {
                    filtered.Insert(0, num);
                }                
            }

            if (filtered.Count > 0)
            {
                Console.WriteLine(String.Join(" ", filtered));
            }
            else Console.WriteLine("Empty");
        }
    }
}
