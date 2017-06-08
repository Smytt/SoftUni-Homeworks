using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int max = GetMax(a, b);
                Console.WriteLine(max);
            }

            if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char max = GetMax(a, b);
                Console.WriteLine(max);
            }

            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string max = GetMax(a, b);
                Console.WriteLine(max);
            }
        }

        static string GetMax(string a, string b)
        {
            if (string.Compare(a,b) < 0)
            {
                return b;
            }
            return a;
        }
        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}
