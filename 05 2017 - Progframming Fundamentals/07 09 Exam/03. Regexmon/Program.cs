using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var bojomon = @"[a-zA-Z]+-[a-zA-Z]+";
            var didimon = @"[^A-Za-z\-]+";
            var turn = 1;
            var pattern = "";

            while (true)
            {
                pattern = bojomon;
                if (turn % 2 != 0) pattern = didimon;
                var match = Regex.Match(input, pattern);

                if (match.Success == false) break;

                Console.WriteLine(match.Value);
                turn++;
                input = input.Substring(input.IndexOf(match.Value) + match.Value.Length);
            }
        }
    }
}
