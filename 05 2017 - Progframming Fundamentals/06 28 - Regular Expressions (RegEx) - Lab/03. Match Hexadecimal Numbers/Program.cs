using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var hex = Regex.Matches(Console.ReadLine(), @"\b(?:0x)?[0-9A-F]+\b").Cast<Match>().ToList();

            Console.WriteLine(string.Join(" ", hex));
        }
    }
}
