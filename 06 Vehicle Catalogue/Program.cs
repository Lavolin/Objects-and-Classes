using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Vehicle_Catalogue
{
    internal class Program
    {
        internal enum VehicleType
        {
            Car,
            Truck
        }
        internal class Vehicle
        {
            public Vehicle(VehicleType type, string model, string color, int horsepower)
            {
                Type = type;
                Model = model;                  // constructor
                Color = color;
                Horsepower = horsepower;
            }
            public VehicleType Type { get; } // private fields
            public string Model { get; }
            public string Color { get; }
            public int Horsepower { get; }

            public override string ToString()
            {
                var builder = new StringBuilder();
                builder.AppendLine($"Type: {Type}");
                builder.AppendLine($"Model: {Model}");
                builder.AppendLine($"Color: {Color}");
                builder.AppendLine($"Horsepower: {Horsepower}");
                return builder.ToString().TrimEnd();
            }
        }
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End") break;
                
                var tokens = cmd.Split();
                VehicleType vehicleType;
                bool isVehicleTypeParsable = Enum.TryParse(tokens[0], true, out vehicleType);
                if (isVehicleTypeParsable)
                {
                    string currModel = tokens[1];
                    string currColor = tokens[2];
                    int currHorsepower = int.Parse(tokens[3]);
                    var currVehicle = new Vehicle(vehicleType, currModel, currColor, currHorsepower);
                    vehicles.Add(currVehicle);
                }

            }

            while (true)
            {
                string cmdArgs = Console.ReadLine();
                if (cmdArgs == "Close the Catalogue") break;

                Vehicle desiredVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == cmdArgs);
                Console.WriteLine(desiredVehicle);
            }
            var cars = vehicles.Where(car => car.Type == VehicleType.Car);
            var trucks = vehicles.Where(truck => truck.Type == VehicleType.Truck);
            double carsAvrHp = cars.Any() ? cars.Average(car => car.Horsepower) : 0.0;
            double trucksAvrHp = trucks.Any() ? trucks.Average(truck => truck.Horsepower) : 0.0;
            Console.WriteLine($"Cars have average horsepower of: {carsAvrHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvrHp:f2}.");
        }
    }
}
