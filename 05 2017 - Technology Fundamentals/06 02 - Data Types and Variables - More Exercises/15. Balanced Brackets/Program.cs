using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isOpenNext = true;
            string isBalanced = "BALANCED";

            for (int i = 0; i < n; i++)
            {
                string currentLine = Console.ReadLine();

                if ((currentLine == "(" && !isOpenNext) || (currentLine == ")" && isOpenNext))
                {
                    isBalanced = "UNBALANCED";
                    break;
                }

                if (currentLine == "(" && isOpenNext)
                {
                    isOpenNext = false;
                }
                if (currentLine == ")" && !isOpenNext)
                {
                    isOpenNext = true;
                }
            }
            if (!isOpenNext) isBalanced = "UNBALANCED";
            Console.WriteLine(isBalanced);
        }
    }
}
