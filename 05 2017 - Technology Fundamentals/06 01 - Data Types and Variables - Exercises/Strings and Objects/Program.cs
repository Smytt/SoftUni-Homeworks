using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = "Hello";
            string part2 = "World";
            object full = part1 + " " + part2;
            string fullSentence = (string)full;

            Console.WriteLine(fullSentence);
        }
    }
}
