using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = Console.ReadLine();
            var input = Console.ReadLine();
            var pattern = @"(^|(?<=[!\?\.]\s))[^!\?\.]*\W" + flag + @"\W[^!\?\.]*(?=[!\?\.])";

            MatchCollection sentences = Regex.Matches(input, pattern);

            foreach(Match sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
