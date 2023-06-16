using System;
using System.Collections.Generic;

namespace Trafic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int cars = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int passedCars = 0;

            while (command != "end")
            {
                if (command != "green")
                {
                    queue.Enqueue(command);
                }else if (command == "green")
                {
                    
                    for (int i = 1; i <= cars; i++) 
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        passedCars++;
                    }
                    
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
