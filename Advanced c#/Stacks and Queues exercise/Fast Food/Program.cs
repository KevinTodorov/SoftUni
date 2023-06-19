using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            for (int i = 0; i < orders.Length; i++)
            {
                int order = queue.Peek();

                if (order <= quantity)
                {
                    quantity -= order;
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    return;
                }
            }

            Console.WriteLine($"Orders complete");
            
        }
    }
}
