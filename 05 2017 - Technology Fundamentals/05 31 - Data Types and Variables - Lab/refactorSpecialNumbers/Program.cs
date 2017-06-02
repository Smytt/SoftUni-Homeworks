using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0; int takova = 0; bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine($"{takova} -> {toe}");
            //    obshto = 0;
            //    ch = takova;
            //}
            
            int n = int.Parse(Console.ReadLine()); 

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                bool isMagic = false;
                int sum = 0;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                isMagic = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isMagic}");
            }

        }
    }
}
