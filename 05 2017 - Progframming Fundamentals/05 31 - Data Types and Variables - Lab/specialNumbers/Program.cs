using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isMagic = false;

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int currentNumber = i;
                while (currentNumber != 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isMagic = true;
                }
                Console.WriteLine($"{i} -> {isMagic}");
                isMagic = false;
            }
        }
    }
}
