﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(EnglishNameOfLastDigit(number));
        }

        static string EnglishNameOfLastDigit(long number)
        {
            number = Math.Abs(number % 10);
            switch (number)
            {
                case 0: return "zero"; 
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five"; 
                case 6: return "six";
                case 7: return "seven"; 
                case 8: return "eight"; 
                case 9: return "nine"; 
                default: return "";    
            }
        }
    }
}
