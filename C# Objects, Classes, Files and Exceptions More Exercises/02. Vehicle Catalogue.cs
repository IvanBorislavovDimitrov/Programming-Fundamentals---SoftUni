using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Program
{
    
    class Program
    {
        class Vehicle
        {
            public string Type { get; set; }
            
            public string Name { get; set; }
            
            public string Colour { get; set; }
            
            public int HorsePower { get; set; }
        }
        static void Main()
        {
            List<Vehicle> vehicles = GetVehicles();
            
            PrintVehicle(vehicles);
        }

        static void PrintVehicle(List<Vehicle> vehicles)
        {
            string nameOfVehicle;
            while ((nameOfVehicle = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle currentVehicle = GetVehicle(vehicles, nameOfVehicle);
                Console.WriteLine($"Type: {currentVehicle.Type[0].ToString().ToUpper() + currentVehicle.Type.Substring(1)}");
                Console.WriteLine($"Model: {currentVehicle.Name}");
                Console.WriteLine($"Color: {currentVehicle.Colour}");
                Console.WriteLine($"Horsepower: {currentVehicle.HorsePower}");
            }
            Console.WriteLine($"Cars have average horsepower of: {AverageHorsepowerOfCars(vehicles):F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {AverageHorsepowerOfTrucks(vehicles):F2}.");
        }

        static double AverageHorsepowerOfTrucks(List<Vehicle> vehicles)
        {
            double sum = 0;
            int counter = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == "truck")
                {
                    sum += vehicle.HorsePower;
                    counter++;
                }
            }
            if (counter == 0)
            {
                return 0;
            }
            return sum / counter;
        }

        static double AverageHorsepowerOfCars(List<Vehicle> vehicles)
        {
            double sum = 0;
            int counter = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == "car")
                {
                    sum += vehicle.HorsePower;
                    counter++;
                }
            }
            if (counter == 0)
            {
                return 0;
            }
            return sum / counter;
        }

        static Vehicle GetVehicle(List<Vehicle> vehicles, string nameOfVehicle)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Name == nameOfVehicle)
                {
                    return vehicle;
                }
            }
            return null;
        }

        static List<Vehicle> GetVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] infoAboutVehicle = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Vehicle vehicle = new Vehicle();
                vehicle.Type = infoAboutVehicle[0].ToLower();
                vehicle.Name = infoAboutVehicle[1];
                vehicle.Colour = infoAboutVehicle[2];
                vehicle.HorsePower = int.Parse(infoAboutVehicle[3].ToLower());
                vehicles.Add(vehicle);
            }
            return vehicles;
        } 
    }
}