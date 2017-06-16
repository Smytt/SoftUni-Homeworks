using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split();
            var phoneBook = new Dictionary<string, string>();

            while (command[0] != "END")
            {
                if(command[0] == "S")
                {
                    if (phoneBook.ContainsKey(command[1]))
                        Console.WriteLine($"{command[1]} -> {phoneBook[command[1]]}");
                    else Console.WriteLine($"Contact {command[1]} does not exist.");
                }
                else if (command[0] == "A")
                {
                    phoneBook[command[1]] = command[2];
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
