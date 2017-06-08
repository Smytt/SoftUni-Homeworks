using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            Console.WriteLine(ReverseDigits(number));
        }

        static string ReverseDigits(string number)
        {
            var reversedString = "";
            for (int i = 1; i <= number.Length; i++)
            {
                reversedString += number[number.Length - i];
            }
            return reversedString;
        }
    }
}
