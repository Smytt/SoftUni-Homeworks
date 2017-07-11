using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsSymmetric(i) && SumDevisableBy7(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool ContainsEvenDigit(int i)
        {
            while (i > 0)
            {
                if ((i % 10) % 2 == 0) return true;
                i /= 10;
            }
            return false;
        }

        static bool SumDevisableBy7(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0) return true;
            return false;
        }

        static bool IsSymmetric(int i)
        {
            int reversed = 0;
            int j = i;

            while(j > 0)
            {
                reversed = reversed * 10 + j % 10;
                j /= 10;
            }

            if (i == reversed) return true;
            return false;
        }
    }
}
