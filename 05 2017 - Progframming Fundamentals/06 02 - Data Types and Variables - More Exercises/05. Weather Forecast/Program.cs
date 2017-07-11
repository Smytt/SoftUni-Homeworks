using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            try
            {
                Convert.ToSByte(number);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    Convert.ToInt32(number);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        Convert.ToInt64(number);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Rainy");
                    }
                }
            }
        }
    }
}
