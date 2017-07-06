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
            var text = "hello";

            var arr = text.ToCharArray();

            var test1 = new string(arr);
            var test2 = string.Join("", arr);

            Console.WriteLine(test1 + " " + test2);

        }
    }
    
}