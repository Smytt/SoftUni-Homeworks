using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            bool isInt = false;
            long sum = 0;

            try
            {
                sbyte number1 = sbyte.Parse(input1);
                sum += 4 * (long)number1;
            }
            catch (Exception)
            {
                int number1 = int.Parse(input1);
                sum += 10 * (long)number1;
                isInt = true;
            }

            if (isInt)
            {
                sbyte number2 = sbyte.Parse(Console.ReadLine());
                sum += 4 * number2;
            }
            else
            {
                int number2 = int.Parse(Console.ReadLine());
                sum += 10 * number2;
            }

            Console.WriteLine(sum);

        }
    }
}
