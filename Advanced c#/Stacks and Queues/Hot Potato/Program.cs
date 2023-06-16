using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(kids);
            int passes = int.Parse(Console.ReadLine());

            while (queue.Count != 1)
            {
                for (int i = 1; i < passes; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
