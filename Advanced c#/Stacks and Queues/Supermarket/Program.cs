using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string name = Console.ReadLine();

            while (name != "End")
            {
                if (name == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else queue.Enqueue(name);

                name = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
