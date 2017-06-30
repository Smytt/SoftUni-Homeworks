using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            var replaced = Regex.Replace(text, $@"{pattern}", new string('*', pattern.Length));
            Console.WriteLine(replaced);
        }
    }
}
