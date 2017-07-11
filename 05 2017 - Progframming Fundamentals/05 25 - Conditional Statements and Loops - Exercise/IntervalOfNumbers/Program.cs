using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            int max;
            int min;

            if ( num1 < num2) { max = num2; min = num1; }
            else { max = num1; min = num2; }

            for (int i = min; i<=max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
