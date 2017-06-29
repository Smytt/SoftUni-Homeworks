using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection validNames = Regex.Matches(Console.ReadLine(), @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            foreach (Match name in validNames)
            {
                Console.Write(name + " ");
            }
        }
    }
}
