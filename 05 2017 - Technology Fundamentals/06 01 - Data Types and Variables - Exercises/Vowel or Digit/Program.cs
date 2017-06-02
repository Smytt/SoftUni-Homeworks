using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (Char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }

            else
            {
                bool isVowel = "aeoiu".IndexOf(input.ToString().ToLower()) >= 0;

                if (isVowel) Console.WriteLine("vowel");
                else Console.WriteLine("other");
            }
            
        }
    }
}
