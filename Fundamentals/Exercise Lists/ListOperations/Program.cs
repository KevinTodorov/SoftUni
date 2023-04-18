using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] help = command.Split();

                switch (help[0])
                {
                    case "Add":
                        AddMethod(numbers, command);
                        break;
                    case "Insert":
                        InsertMethod(numbers, command);
                        break;
                    case "Remove":
                        RemoveMethod(numbers, command);
                        break;
                    case "Shift":
                        if (help[1] == "left")
                        {
                            LeftShiftMethod(numbers, command);
                        }
                        else
                        {
                            RightShiftMethod(numbers, command);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void AddMethod(List<int> numbers, string command)
        {
            string[] help = command.Split();
            int number = int.Parse(help[1]);
            numbers.Add(number);
        }

        private static void InsertMethod(List<int> numbers, string command)
        {
            string[] help = command.Split();
            int index = int.Parse(help[2]);
            int number = int.Parse(help[1]);
            if (index >= numbers.Count && index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            numbers.Insert(index, number);
        }

        private static void RemoveMethod(List<int> numbers, string command)
        {
            string[] help = command.Split();
            int index = int.Parse(help[1]);
            if (index >= numbers.Count && index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            numbers.RemoveAt(index);
        }

        private static void LeftShiftMethod(List<int> numbers, string command)
        {
            string[] help = command.Split();
            int count = int.Parse(help[2]);           

            for (int i = 0; i < count; i++)
            {
                int firstNum = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNum);
            }
        }

        private static void RightShiftMethod(List<int> numbers, string command)
        {
            string[] help = command.Split();
            int count = int.Parse(help[2]);
          

            for (int i = 0; i < count; i++)
            {
                int lastNum = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNum);

            }
        }
    }
}
