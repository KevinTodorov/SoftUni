using System;
using System.Collections.Generic;
using System.Linq;

namespace CrossroadsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeTime = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            string command = Console.ReadLine();

            while (command != "END")
            {
                string car = string.Empty;
                int greenSeconds = greenLight;
                int freeSeconds = freeTime;
                int greenSecondsCounter = 0;
                int freeSecondsCounter = 0;
                if (command != "green")
                {
                    cars.Enqueue(command);
                }else if (command == "green")
                {
                    while (greenSeconds + freeSeconds > 0 && cars.Count > 0)
                    {
                        car = cars.Peek();
                        if (greenSeconds > 0)
                        {
                            for (int i = 0; i < greenSeconds; i++)
                            {
                                if (car.Length == 0)
                                {
                                    break;
                                }

                                car = car.Remove(0, 1);
                                greenSecondsCounter++;
                            }

                            greenSeconds -= greenSecondsCounter;
                            if (car.Length > 0)
                            {
                                for (int i = 0; i < freeSeconds; i++)
                                {
                                    if (car.Length == 0)
                                    {
                                        break;
                                    }

                                    car = car.Remove(0, 1);
                                    freeSecondsCounter++;
                                }

                                freeSeconds -= freeSecondsCounter;
                            }

                            if (car.Length > 0)
                            {
                                Console.WriteLine($"A crash happened!");
                                Console.WriteLine($"{cars.Dequeue()} was hit at {car[0]}.");
                                return;
                            }
                            else
                            {
                                passedCars++;
                                cars.Dequeue();
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Everyone is safe.\r\n{passedCars} total cars passed the crossroads.");
        }
    }
}
