using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var userPlates = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split().ToList();

                if(command.Count == 3)
                {
                    

                    if(userPlates.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userPlates[command[1]]}");
                        continue;
                    }

                    if (!licenseChecker(command[2]))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {command[2]}");
                        continue;
                    }

                    if (userPlates.ContainsValue(command[2]))
                    {
                        Console.WriteLine($"ERROR: license plate {command[2]} is busy");
                        continue;
                    }

                    userPlates.Add(command[1], command[2]);
                    Console.WriteLine($"{command[1]} registered {userPlates[command[1]]} successfully");
                    
                }
                else
                {
                    if(userPlates.ContainsKey(command[1]))
                    {
                        userPlates.Remove(command[1]);
                        Console.WriteLine($"user {command[1]} unregistered successfully");
                    }
                    else
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                }
            }

            foreach (var user in userPlates)
            {
                Console.WriteLine("{0} => {1}", user.Key, user.Value);
            }
        }

        static bool licenseChecker(string x)
        {
            if (x.Length != 8) return false;
            var middlePart = string.Join("", x.Skip(2).Take(4));
            var endParts = string.Join("", x.Take(2).Concat(x.Skip(6).Take(2)));
            var allowedLetters = @"^[A-Z]+$";
            var allowedDigits = @"^[0-9]+$";
            if (Regex.IsMatch(middlePart, allowedDigits) && Regex.IsMatch(endParts, allowedLetters))
                return true;
            return false;
        }
    }
}
