using System;
using System.Linq;

namespace Speed_Racing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var car = new Car[lines];
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                car[i] = new Car(input[0], fuelAmount, fuelConsumption);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandInArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = commandInArr[1];
                double amountOfKm = double.Parse(commandInArr[2]);
                car.Where(c => c.Model == carModel).ToList().ForEach(c => c.Drive(amountOfKm));
                command = Console.ReadLine();
            }

            foreach (Car vehicle in car)
            {
                Console.WriteLine($"{vehicle.Model} {vehicle.FuelAmount:f2} {vehicle.TraveledDistance}");
            }
        }
    }
}
