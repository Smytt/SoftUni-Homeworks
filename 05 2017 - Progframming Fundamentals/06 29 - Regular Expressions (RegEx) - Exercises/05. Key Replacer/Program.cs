using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keys = Console.ReadLine();
            var text = Console.ReadLine();

            var startPattern = @"^[A-Za-z]+(?=[\|\<\\])";
            var endPattern = @"(?<=[\|\<\\])[A-Za-z]+$";

            var startKey = Regex.Match(keys, startPattern);
            var endKey = Regex.Match(keys, endPattern);

            var regex = startKey + @"(.*?)" + endKey;
            var matches = Regex.Matches(text, regex);

            if (matches.Count == 0) Console.WriteLine("Empty result");
            else
            {
                foreach (Match match in matches)
                {
                    Console.Write(match.Groups[1]);
                }
            }

        }
    }
}
