using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allWords = Console.ReadLine()
                .Split(new[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowercase = new List<string>();
            List<string> uppercase = new List<string>();
            List<string> mixed = new List<string>();

            foreach (var word in allWords)
            {
                var loweraseChar = false;
                var uppercaseChar = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        uppercaseChar = true;
                    }
                    else if (char.IsLower(word[i]))
                    {
                        loweraseChar = true;
                    }
                    else
                    {
                        loweraseChar = false;
                        uppercaseChar = false;
                        break;
                    }


                    if (uppercaseChar == true && loweraseChar == true) break;
                }

                if (loweraseChar == true)
                {
                    if (uppercaseChar == true) mixed.Add(word);
                    else lowercase.Add(word);
                }
                else
                {
                    if (uppercaseChar == false) mixed.Add(word);
                    else uppercase.Add(word);
                }


                uppercaseChar = false;
                loweraseChar = false;
            }

            Console.WriteLine($"Lower-case: {String.Join(", ", lowercase)}");
            Console.WriteLine($"Mixed-case: {String.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", uppercase)}");
        }
    }
}
