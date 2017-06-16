using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split();
            var phoneBook = new SortedDictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "S")
                {
                    if (phoneBook.ContainsKey(command[1]))
                        Console.WriteLine($"{command[1]} -> {phoneBook[command[1]]}");
                    else Console.WriteLine($"Contact {command[1]} does not exist.");
                }
                else if (command[0] == "A")
                {
                    phoneBook[command[1]] = command[2];
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var person in phoneBook)
                        Console.WriteLine($"{person.Key} -> {person.Value}");
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
