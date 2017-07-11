using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            while (true)
            {
                var input = Console.ReadLine().Split().ToList();
                string pattern = Regex.Escape(input[0]) + "{" + input[1] + ",}";

                var match = Regex.Match(text, pattern);

                if (match.Length == 0) continue;

                Console.WriteLine($"Hideout found at index {text.IndexOf(match.Value)} and it is with size {match.Value.Length}!");
                break;
            }
        }
    }
}
