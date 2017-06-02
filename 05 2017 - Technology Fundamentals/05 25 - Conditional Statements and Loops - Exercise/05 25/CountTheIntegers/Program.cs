using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var error = false;
            int counter = 0;

            do
            {
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    error = true;
                }
            }
            while (error != true);

            Console.WriteLine(counter);
        }
    }
}
