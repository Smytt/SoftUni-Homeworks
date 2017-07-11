using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSquare(int.Parse(Console.ReadLine()));
        }

        static void PrintSquare(int number)
        {
            PrintTopAndBottom(number);
            for (int i = 1; i <= number - 2; i++)
            {
                PrintOneLineOfBody(number);
            }
            PrintTopAndBottom(number);
        }

        static void PrintOneLineOfBody(int number)
        {
            Console.Write("-");
            for (int i = 1; i <= number - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void PrintTopAndBottom(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }
    }
}
