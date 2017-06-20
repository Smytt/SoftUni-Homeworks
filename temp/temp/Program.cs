using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            int result = 0;
            Console.WriteLine(result);

            if (int.TryParse("t", out result)) { }

            Console.WriteLine(result);
        }
    }
}