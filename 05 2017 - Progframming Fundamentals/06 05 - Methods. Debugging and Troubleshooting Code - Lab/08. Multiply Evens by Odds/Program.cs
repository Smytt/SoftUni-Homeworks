using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(MultipleOfSumOfOddsAndSumOfEvens(number));
        }

        private static int MultipleOfSumOfOddsAndSumOfEvens(int number)
        {
            number = Math.Abs(number);
            int sumOfOdds = 0;
            int sumOfEvens = 0;

            while (number > 0)
            {
                if ((number % 10) % 2 == 0) sumOfEvens += number % 10;
                else sumOfOdds += number % 10;
                number /= 10;
            }

            return sumOfOdds * sumOfEvens;
        }
    }
}
