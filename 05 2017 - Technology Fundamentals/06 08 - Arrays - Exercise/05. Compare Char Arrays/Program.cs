using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] line1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] line2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool found = false;

            int longer = Math.Max(line1.Length, line2.Length);

            for (int i = 0; i < longer; i++)
            {
                try
                {
                    if (i == line1.Length || line1[i] < line2[i])
                    {
                        Console.WriteLine(String.Join("", line1));
                        Console.WriteLine(String.Join("", line2));
                        found = true;
                        break;
                    }
                }
                catch (Exception) { }
                
                try
                {
                    if (i == line2.Length || line2[i] < line1[i])
                    {
                        Console.WriteLine(String.Join("", line2));
                        Console.WriteLine(String.Join("", line1));
                        found = true;
                        break;
                    }
                }
                catch(Exception) { }

                if (line1[i] == line2[i]) continue;
            }
            if(!found)
            {
                Console.WriteLine(String.Join("", line2));
                Console.WriteLine(String.Join("", line1));
            }
        }
    }
}
