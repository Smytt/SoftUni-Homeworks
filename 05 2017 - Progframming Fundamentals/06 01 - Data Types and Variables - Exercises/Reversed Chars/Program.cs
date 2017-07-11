using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string final = "";
            for (int i = 0; i < 3; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                final = currentChar + final;
            }

            Console.WriteLine(final);
        }
    }
}
