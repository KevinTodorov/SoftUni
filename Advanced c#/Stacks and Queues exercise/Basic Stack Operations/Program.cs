using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
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

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfElementsToPush; i++)
            {
                stack.Push(elements[i]);
            }

           
            for (int i = 0; i < numberOfElemtnsToPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(element))
                {
                    Console.WriteLine("true");
                }else Console.WriteLine(stack.Min());
            }else Console.WriteLine(0);
            
        }
    }
}
