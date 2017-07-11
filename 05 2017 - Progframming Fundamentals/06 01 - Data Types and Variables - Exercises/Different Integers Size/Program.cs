using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            bool x1, x2, x3, x4, x5, x6, x7;
            bool cantFit = true;

            try
            {
                long a = Convert.ToInt64(n);
                x1 = true;
                cantFit = false;
            }

            catch (Exception)
            {
                x1 = false;
            }

            try
            {
                uint b = Convert.ToUInt32(n);
                x2 = true;
                cantFit = false;
            }
            catch (Exception)
            {
                x2 = false;
            }

            try
            {
                int c = Convert.ToInt32(n);
                x3 = true;
                cantFit = false;

            }
            catch (Exception)
            {
                x3 = false;
            }
            try
            {
                ushort d = Convert.ToUInt16(n);
                x4 = true;
                cantFit = false;

            }
            catch (Exception)
            {
                x4 = false;
            }
            try
            {
                short e = Convert.ToInt16(n);
                x5 = true;
                cantFit = false;

            }
            catch (Exception)
            {
                x5 = false;
            }
            try
            {
                byte f = Convert.ToByte(n);
                x6 = true;
                cantFit = false;

            }
            catch (Exception)
            {
                x6 = false;
            }
            try
            {
                sbyte g = Convert.ToSByte(n);
                x7 = true;
                cantFit = false;
            }
            catch (Exception)
            {
                x7 = false;
            }

            if (cantFit) Console.WriteLine($"{n} can't fit in any type");
            else
            {
                Console.WriteLine($"{n} can fit in:");
                if (x7) Console.WriteLine("* sbyte");
                if (x6) Console.WriteLine("* byte");
                if (x5) Console.WriteLine("* short");
                if (x4) Console.WriteLine("* ushort");
                if (x3) Console.WriteLine("* int");
                if (x2) Console.WriteLine("* uint");
                if (x1) Console.WriteLine("* long");
            }
        }
    }
}
