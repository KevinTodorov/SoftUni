using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps= int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < petrolPumps; i++)
            {
                int[] petrolPumpInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(petrolPumpInfo);
            }

            
            int index = 0;
            while (true)
            {
                int totalFuel = 0;
                foreach (var petrolPump in queue)
                {
                    int amount = petrolPump[0];
                    int distance = petrolPump[1];
                    totalFuel += amount - distance;
                    if (totalFuel < 0)
                    {
                        queue.Enqueue(queue.Dequeue());
                        index++;
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
