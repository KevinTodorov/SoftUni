using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_Catalouge
{
    class Vehicles
    {
        private string typeOfVehicle_;
        private string model_;
        private string color_;
        private double horsepower_;

        public Vehicles(string typeOfVehicle, string model, string color, double horsepower)
        {
            TypeOfVehicle = typeOfVehicle;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string TypeOfVehicle { get => typeOfVehicle_; set => typeOfVehicle_ = value; }
        public string Model { get => model_; set => model_ = value; }
        public string Color { get => color_; set => color_ = value; }
        public double Horsepower { get => horsepower_; set => horsepower_ = value; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Type: {TypeOfVehicle}");
            builder.AppendLine($"Model: {Model}");
            builder.AppendLine($"Color: {Color}");
            builder.AppendLine($"Horsepower: {Horsepower}");

            return builder.ToString().TrimEnd();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicles> cars = new List<Vehicles>();
            List<Vehicles> trucks = new List<Vehicles>();
            List<Vehicles> vehicles = new List<Vehicles>();

            while (input != "End")
            {
                string[] inputInArr = input.Split();

                string type = inputInArr[0];
                string model = inputInArr[1];
                string color = inputInArr[2];
                double hp = double.Parse(inputInArr[3]);

                Vehicles vehicle = new Vehicles(type, model, color, hp);
                if (type == "car")
                {
                    vehicle.TypeOfVehicle = "Car";
                    cars.Add(vehicle);
                }else if (type == "truck")
                {
                    vehicle.TypeOfVehicle = "Truck";
                    trucks.Add(vehicle);
                }
                vehicles.Add(vehicle);
                input = Console.ReadLine();
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Close the Catalogue")
                {
                    break;
                }

                Vehicles deseriedVehicles = vehicles.FirstOrDefault(vehicle => vehicle.Model == command);
                Console.WriteLine(deseriedVehicles);
            }

            double carAvgHp = cars.Any() ? cars.Average(car => car.Horsepower) : 0.0;
            double truckAvgHp = trucks.Any() ? trucks.Average(truck => truck.Horsepower) : 0.0;

            Console.WriteLine($"Cars have average horsepower of: {carAvgHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvgHp:f2}.");
        }
    }
}
