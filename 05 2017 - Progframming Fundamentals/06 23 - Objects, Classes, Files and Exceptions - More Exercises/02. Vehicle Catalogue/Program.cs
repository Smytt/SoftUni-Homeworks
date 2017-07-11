using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = ReadVehicles();

            PrintVehicles(vehicles);

            var avgCars = 0.0;
            var avgTrucks = 0.0;

            if (vehicles.Where(x => x.type == "car").ToList().Count > 0)
            avgCars = vehicles.Where(x => x.type == "car").Select(x => x.horsePower).Sum() / vehicles.Where(x => x.type == "car").ToList().Count;

            if (vehicles.Where(x => x.type == "truck").ToList().Count > 0)
            avgTrucks = vehicles.Where(x => x.type == "truck").Select(x => x.horsePower).Sum() / vehicles.Where(x => x.type == "truck").ToList().Count;

            Console.WriteLine($"Cars have average horsepower of: {avgCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTrucks:f2}.");

        }

        private static void PrintVehicles(List<Vehicle> vehicles)
        {
            var command = Console.ReadLine();

            while(command != "Close the Catalogue")
            {
                var index = vehicles.FindIndex(x => x.model == command);
                Console.WriteLine($"Type: {vehicles[index].type.ToUpper()[0] + vehicles[index].type.ToLower().Substring(1)}");
                Console.WriteLine($"Model: {vehicles[index].model}");
                Console.WriteLine($"Color: {vehicles[index].color}");
                Console.WriteLine($"Horsepower: {vehicles[index].horsePower}");

                command = Console.ReadLine();
            }
        }

        private static List<Vehicle> ReadVehicles()
        {
            var vehicles = new List<Vehicle>();
            var command = Console.ReadLine().Split().ToList();

            while(command[0] != "End")
            {
                var vehicle = new Vehicle();
                vehicle.type = command[0].ToLower();
                vehicle.model = command[1];
                vehicle.color = command[2];
                vehicle.horsePower = double.Parse(command[3]);
                vehicles.Add(vehicle);

                command = Console.ReadLine().Split().ToList();
            }

            return vehicles;
            
        }
    }

    internal class Vehicle
    {
        public string type { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public double horsePower { get; set; }
    }
}
