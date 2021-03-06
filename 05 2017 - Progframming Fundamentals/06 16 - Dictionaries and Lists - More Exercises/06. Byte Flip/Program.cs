﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine()
                .Split()
                .Where(x => x.Length == 2)
                .Select(x => string.Join("", x.ToCharArray().Reverse().ToList()))
                .Reverse()
                .Select(x => Convert.ToInt32(x, 16))
                .Select(x => (char)x)
                .ToList()
                ;


            Console.WriteLine(string.Join("", sequence));
        }
    }
}
