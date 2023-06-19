using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string commands = Console.ReadLine();

                if (commands == "Play")
                {
                    queue.Dequeue();
                }else if (commands.Contains("Add"))
                {
                    string song = commands.Substring(4, commands.Length - 4);
                    
                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }else Console.WriteLine($"{song} is already contained!");
                }else Console.WriteLine($"{string.Join(", ", queue)}");
            }

            Console.WriteLine("No more songs!");
        }
    }  
}
