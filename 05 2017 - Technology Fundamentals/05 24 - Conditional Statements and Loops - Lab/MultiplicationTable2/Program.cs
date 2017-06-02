using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
                i++;
            }

            while (i <= 10);
        }
    }
}
