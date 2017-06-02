using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sms = "";

            for (int i = 1; i <= n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                if (m == 0) sms += " ";

                else
                {
                    
                    int length = m.ToString().Length;
                    int number = m % 10;
                    int add = 0;
                    
                    if (number > 7)
                    {
                        add = 1;
                    }
                    char c = (char)(96 + (number - 2) * 3 + length + add);
                    sms += c;
                }
            }

            Console.WriteLine(sms);


        }
    }
}
