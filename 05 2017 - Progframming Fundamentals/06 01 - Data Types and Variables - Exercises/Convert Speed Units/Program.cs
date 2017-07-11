using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            float mps = (float)distance/(seconds+minutes*60+hours*60*60);
            float kmph = mps * 3600 / 1000;
            float mph = kmph / 1.609f;

            Console.WriteLine($"{mps,7}");
            Console.WriteLine($"{kmph,7}");
            Console.WriteLine($"{mph,7}");
        }
    }
}
