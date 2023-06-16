using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] arr = command.Split();
                string action = arr[0].ToLower();

                if (action == "add")
                {
                    int firstNum = int.Parse(arr[1]);
                    int secondNum = int.Parse(arr[2]);

                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }else if (action == "remove")
                {
                    int times = int.Parse(arr[1]);
                    if (stack.Count > times)
                    {
                        for (int i = 0; i < times; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine();
            }

            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
