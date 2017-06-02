using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(integer, 16).ToUpper());
            Console.WriteLine(Convert.ToString(integer, 2));
        }
    }
}
