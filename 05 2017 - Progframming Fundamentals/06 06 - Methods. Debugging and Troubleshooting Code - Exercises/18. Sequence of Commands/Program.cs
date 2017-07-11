using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Sequence_of_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            char ArgumentsDelimiter = ' ';

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine().Trim();
            string[] stringParams = command.Split(ArgumentsDelimiter);

            while (!stringParams[0].Equals("stop"))
            {
                PerformAction(array, stringParams);
                PrintArray(array);

                command = Console.ReadLine().Trim();
                stringParams = command.Split(ArgumentsDelimiter);
            }
        }

        static void PerformAction(long[] arr, string[] stringParams)
        {
            int pos = 0;
            int value = 0;

            switch (stringParams[0])
            {
                case "multiply":
                    pos = int.Parse(stringParams[1]);
                    value = int.Parse(stringParams[2]);
                    arr[pos - 1] *= value;
                    break;
                case "add":
                    pos = int.Parse(stringParams[1]);
                    value = int.Parse(stringParams[2]);
                    arr[pos - 1] += value;
                    break;
                case "subtract":
                    pos = int.Parse(stringParams[1]);
                    value = int.Parse(stringParams[2]);
                    arr[pos - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long rightMost = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = rightMost;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long leftMost = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = leftMost;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
