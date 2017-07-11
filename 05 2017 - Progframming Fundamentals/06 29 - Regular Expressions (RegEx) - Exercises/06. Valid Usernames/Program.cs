using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=[ \/\\\(\)]))[A-Za-z]\w{2,24}($|(?=[ \/\\\(\)]))";

            var matches = Regex.Matches(Console.ReadLine(), pattern).Cast<Match>().ToList();

            var index = 0;
            var sum = 0;
            for (int i = 0; i < matches.Count-1; i++)
            {
                var tempSum = matches[i].Length + matches[i + 1].Length;
                if (tempSum > sum)
                {
                    index = i;
                    sum = tempSum;
                }
            }

            Console.WriteLine(matches[index]);
            Console.WriteLine(matches[index+1]);
        }
    }
}
