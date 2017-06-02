using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string wholeNum = "";
            for (int i = 1; i <= 4; i++)
            {
                int number = int.Parse(Console.ReadLine());
                wholeNum += number.ToString("D4");
                if (i != 4) wholeNum += " ";
            }
            Console.WriteLine(wholeNum);
            
        }
    }
}
