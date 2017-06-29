using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359([- ])2\1\d{3}\1\d{4}\b";
            MatchCollection matches = Regex.Matches(Console.ReadLine(), regex);

            var validPhones = matches.Cast<Match>().ToList();

            Console.WriteLine(String.Join(", ", validPhones));
        }
    }
}
