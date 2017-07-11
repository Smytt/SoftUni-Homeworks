using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var mine = Console.ReadLine();
                                           // BOOBIES BEWBS
            var matches = Regex.Matches(mine, @"<(.)(.)>").Cast<Match>()
                .ToDictionary(x => x.Value, x => Math.Abs((int)x.Groups[1].Value[0] - (int)x.Groups[2].Value[0]));

            foreach(var match in matches)
            {
                var regex = ".{0," + match.Value + "}" + match.Key + ".{0," + match.Value +"}";
                mine = Regex.Replace(mine, regex, x => new string('_', x.Length));
            }

            Console.WriteLine(mine);
        }
    }
}
