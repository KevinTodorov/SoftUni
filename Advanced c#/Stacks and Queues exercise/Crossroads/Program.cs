using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            string command = Console.ReadLine();
            int passedCars = 0;

            while (command != "END")
            {
                int leftSeconds = greenLightSeconds;
                int leftFreeWindow = freeWindow;

                if (command != "green")
                {
                    queue.Enqueue(command);
                }else if (command == "green")
                {
                    for (int i = 0; i <= queue.Count; i++)
                    {
                        string car = queue.Dequeue();
                        string fullCarName = car;
                        if (leftSeconds > 0)
                        {
                            int lenghtOfCar = car.Length;
                            for (int b = leftSeconds; b > 0; b--)
                            {
                                car = car.Remove(0, 1);
                                leftSeconds--;
                                if (car.Length == 0)
                                {
                                    passedCars++;
                                    break;
                                }
                            }

                            if (car.Length > 0 &&  leftFreeWindow > 0)
                            {
                                for (int b = leftFreeWindow; b > 0; b--)
                                {
                                   car = car.Remove(0, 1);
                                    leftFreeWindow--;
                                    if (car.Length == 0)
                                    {
                                        passedCars++;
                                        break;
                                    }
                                }

                            }
                            if (car.Length > 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{fullCarName} was hit at {car[0]}.");
                                return;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
