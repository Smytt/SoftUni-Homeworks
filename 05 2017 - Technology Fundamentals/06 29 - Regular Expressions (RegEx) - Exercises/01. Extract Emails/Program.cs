using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))(?<mail>[0-9A-Za-z]([0-9A-Za-z_\-\.]*[0-9A-Za-z])?@[0-9A-Za-z]([0-9A-Za-z\-]*[0-9A-Za-z])?(\.[0-9A-Za-z]([0-9A-Za-z\-]*[0-9A-Za-z])?)+)\b";

            var emails = Regex.Matches(Console.ReadLine(), pattern);

            foreach(Match mail in emails)
            {
                Console.WriteLine(mail);
            }
        }
    }
}
