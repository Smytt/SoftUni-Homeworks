﻿using System;
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
            int[] num = { 2147483647, 5 };
            long big = 2147483648;

            if (big < num.Sum(x => (long)x)) Console.WriteLine("YES");

        }
    }
    
}