using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    class Progra1m
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            int sum = sequence[0];

            while (true)
            {
                int tempIndex = index;      
                try
                {
                    index = tempIndex + sequence[tempIndex];
                    sum += sequence[index];
                }
                catch (Exception)
                {
                    try
                    {
                        index = tempIndex - sequence[tempIndex];
                        sum += sequence[index];
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(sum);

        }
    }
}
