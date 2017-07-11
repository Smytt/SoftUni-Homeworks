using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            int minutes = 0;
            int seconds = 0;
            double bars = beats / 4.0;

            minutes = beats / bpm;
            seconds = (beats % bpm) * 60 / bpm;

            Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");
        }
    }
}
