using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var matches = Regex.Split(Console.ReadLine(), "@").ToList();

            var sumleft = 0;
            var sumright = 0;

            foreach (var letter in matches[0])
            {
                sumleft += (int)letter;
            }
            foreach (var letter in matches[1])
            {
                sumright += (int)letter;
            }

            if (sumleft - sumright >= 0) Console.WriteLine("Call her!");
            else Console.WriteLine("She is not the one.");
        }
    }
}
