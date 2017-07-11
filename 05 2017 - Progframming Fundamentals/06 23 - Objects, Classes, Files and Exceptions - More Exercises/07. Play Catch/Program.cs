using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine().Split().Select(int.Parse).ToList();
            var exceptions = 0;

            while (exceptions != 3)
            {
                var command = Console.ReadLine().Split().ToList();
                var param1 = 0;
                var param2 = 0;

                if (command[0] == "Replace")
                {
                    try
                    {
                        param1 = int.Parse(command[1]);
                        param2 = int.Parse(command[2]);
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }

                    try
                    {
                        collection[param1] = param2;
                    }
                    catch
                    {
                        Console.WriteLine("The index does not exist!");
                        exceptions++;
                        continue;
                    }
                }

                if (command[0] == "Print")
                {
                    try
                    {
                        param1 = int.Parse(command[1]);
                        param2 = int.Parse(command[2]);
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }


                    try
                    {
                        collection[param1] = collection[param1];
                        collection[param2] = collection[param2];
                        Console.WriteLine(string.Join(", ",
                            collection.Skip(param1).Take(param2 - param1 + 1)));
                    }
                    catch
                    {
                        Console.WriteLine("The index does not exist!");
                        exceptions++;
                        continue;
                    }

                }
                if (command[0] == "Show")
                {
                    try
                    {
                        param1 = int.Parse(command[1]);
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                        continue;
                    }
                    try
                    {
                        Console.WriteLine(collection[param1]);
                    }
                    catch
                    {
                        Console.WriteLine("The index does not exist!");
                        exceptions++;
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
