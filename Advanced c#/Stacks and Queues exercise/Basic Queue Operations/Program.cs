using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] actions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfElementsToPush = actions[0];
            int numberOfElemtnsToPop = actions[1];
            int element = actions[2];

            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numberOfElementsToPush; i++)
            {
                queue.Enqueue(elements[i]);
            }


            for (int i = 0; i < numberOfElemtnsToPop; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }

            if (queue.Count > 0)
            {
                if (queue.Contains(element))
                {
                    Console.WriteLine("true");
                }
                else Console.WriteLine(queue.Min());
            }
            else Console.WriteLine(0);

        }
    }
}
