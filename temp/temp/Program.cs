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
            List<int> list = new List<int>();
            for (int i = 11; i < 100; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("Sfsdf");
            Console.WriteLine(list.IndexOf(2));
        }
    }
}