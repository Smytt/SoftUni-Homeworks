using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string oddOrEeadlven = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string concat = "";

            for (int i = 1; i <= n; i++)
            {
                string currentString = Console.ReadLine();

                if (oddOrEeadlven == "odd" && i % 2 == 1)
                {
                    concat += currentString;
                    concat += delimiter;
                }

                if (oddOrEeadlven == "even" && i % 2 == 0)
                {
                    concat += currentString;
                    concat += delimiter;
                }
            }
            Console.WriteLine(concat.Remove(concat.Length-1));

        }
    }
}
