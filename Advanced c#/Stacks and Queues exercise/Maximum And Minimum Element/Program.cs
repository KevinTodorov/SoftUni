using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_And_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int queries = int.Parse(Console.ReadLine());

            for (int i = 0; i < queries; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        int element = int.Parse(command[1]);
                        stack.Push(element);
                        break;
                    case "2":
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case "3":
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case "4":
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", stack)}");
            }
        }
    }
}
