using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPhotos = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long totalSeconds = totalPhotos * filterTime + ((long)Math.Ceiling(totalPhotos * filterFactor / 100.0)) * uploadTime;
            long totalMinutes = totalSeconds / 60;
            long totalHours = totalMinutes / 60;
            long totalDays = totalHours / 24;
            
            Console.WriteLine($"{totalDays:d1}:{totalHours%24:d2}:{totalMinutes%60:d2}:{totalSeconds%60:d2}");
        }
    }
}
