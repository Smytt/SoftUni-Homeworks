using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split().ToList();

            var dict = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else dict[item] = 1;
            }

            var oddTimesPresent = new List<string>();

            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                    oddTimesPresent.Add(item.Key);
            }

            Console.WriteLine(String.Join(", ", oddTimesPresent));

        }
    }
}
