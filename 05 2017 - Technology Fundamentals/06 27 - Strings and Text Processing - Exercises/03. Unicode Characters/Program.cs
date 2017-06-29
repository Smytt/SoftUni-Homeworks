using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            foreach(var c in text)
            {
                Console.Write($"\\u{((int)c).ToString("X4").ToLower()}");
            }
        }
    }
}
