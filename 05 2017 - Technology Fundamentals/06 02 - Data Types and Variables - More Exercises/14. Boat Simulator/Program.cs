using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            byte boat1Points = 0;
            byte boat2Points = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();

                if (command == "UPGRADE")
                {
                    boat1 = (char)(3 + (int)boat1);
                    boat2 = (char)(3 + (int)boat2);
                }

                else
                {
                    if ( i % 2 == 1)
                    {
                        boat1Points += (byte)command.Length;
                    }
                    else
                    {
                        boat2Points += (byte)command.Length;
                    }
                }

                if (boat1Points >= 50 || boat2Points >= 50)
                {
                    break;
                }
            }

            if (boat1Points > boat2Points)
            {
                Console.WriteLine(boat1);
            }
            else
            {
                Console.WriteLine(boat2);
            }
        }
    }
}
