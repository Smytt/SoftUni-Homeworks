using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double currentPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double priceChange = double.Parse(Console.ReadLine());
                double difference = Proc(currentPrice, priceChange);
                bool isSignificant = isChangeSignificant(difference, threshold);
                string message = Get(priceChange, currentPrice, difference, isSignificant);
                Console.WriteLine(message);
                currentPrice = priceChange;
            }
        }

        static string Get(double c, double currentPrice, double difference, bool etherTrueOrFalse)
        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", c);
            }
            else if (!etherTrueOrFalse)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", currentPrice, c, difference*100);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", currentPrice, c, difference * 100);
            }
            else if (etherTrueOrFalse && (difference < 0))
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", currentPrice, c, difference * 100);
            return message;
        }

        static bool isChangeSignificant(double threshold, double significance)
        {
            if (Math.Abs(threshold) >= significance)
            {
                return true;
            }
            return false;
        }

        static double Proc(double l, double c)
        {
            double r = (c - l) / l;
            return r;
        }
    }
}
