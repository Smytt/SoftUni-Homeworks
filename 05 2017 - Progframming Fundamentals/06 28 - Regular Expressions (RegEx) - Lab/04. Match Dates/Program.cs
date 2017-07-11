using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})([\.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            MatchCollection validDates = Regex.Matches(Console.ReadLine(), regex);

            foreach (Match date in validDates)
            {
                var str = new StringBuilder();
                var day = date.Groups["day"];
                var month = date.Groups["month"];
                var year = date.Groups["year"];
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
