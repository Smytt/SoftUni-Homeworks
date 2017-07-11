using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            sbyte n = sbyte.Parse(Console.ReadLine());
            long thiefID = Int64.MinValue;
            long biggestID = Int64.MaxValue;

            if (dataType == "sbyte")
            {
                thiefID = SByte.MinValue;
                biggestID = SByte.MaxValue;
                Convert.ToSByte(thiefID);
            }
            else if (dataType == "int")
            {
                thiefID = Int32.MinValue;
                biggestID = Int32.MaxValue;
                Convert.ToInt32(thiefID);
            }
            else if (dataType == "long")
            {
                thiefID = Int64.MinValue;
                biggestID = Int64.MaxValue;
            }

            for (int i = 0; i < n; i++)
            {
                long currentID = long.Parse(Console.ReadLine());

                if (dataType == "sbyte")
                {
                    try
                    {
                        Convert.ToSByte(currentID);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                else if (dataType == "int")
                {
                    try
                    {
                        Convert.ToInt32(currentID);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                if (currentID > thiefID)
                {
                    thiefID = currentID;
                }

            }
            Console.WriteLine(thiefID);
        }
    }
}
