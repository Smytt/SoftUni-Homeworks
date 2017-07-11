using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> searchedNumber =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var found = false;

            for (int i = searchedNumber[1]; i < searchedNumber[0]; i++)
            {
                if (numbers[i] == searchedNumber[2])
                {
                    found = true;
                    break;
                }
            }

            if (found) Console.WriteLine("YES!");
            else Console.WriteLine("NO!");
        }
    }
}
