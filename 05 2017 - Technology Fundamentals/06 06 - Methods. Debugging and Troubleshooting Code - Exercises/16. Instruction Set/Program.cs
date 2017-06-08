using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _16.Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine().ToUpper();

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                BigInteger result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            result = operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            result = operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                }

                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
        }
    }
}
