using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandInArray = command.Split(", ");
                string action = commandInArray[0];
                string license = commandInArray[1];

                if (action == "IN")
                {
                    if (!cars.Contains(license))
                    {
                        cars.Add(license);
                    }
                }else if (action == "OUT")
                {
                    cars.Remove(license);
                }
                command = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine($"{car}");   
                }
            }else Console.WriteLine("Parking Lot is Empty");
        }
    }
}
