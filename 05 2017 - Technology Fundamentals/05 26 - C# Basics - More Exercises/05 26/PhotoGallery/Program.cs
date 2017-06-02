using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var day = Console.ReadLine();
            var month = Console.ReadLine();
            var year = Console.ReadLine();
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var size = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var measure = "";
            var orientation = "";
            double formatedSize = 0.0;

            if (size <= 999)
            {
                measure = "B";
                formatedSize = size;
            }
            else if (size <= 999999)
            {
                measure = "KB";
                formatedSize = size / 1000;
            }
            else
            {
                measure = "MB";
                formatedSize = size / 1000000;
            }

            if (h > w)
            {
                orientation = "portrait";
            }
            else if (h < w)
            {
                orientation = "landscape";
            }
            else orientation = "square";

            Console.WriteLine($"Name: DSC_{num:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hour:d2}:{minute:D2}");
            Console.WriteLine($"Size: {Math.Round(formatedSize, 3)}{measure}");
            Console.WriteLine($"Resolution: {w}x{h} ({orientation})");
        }
    }
}
