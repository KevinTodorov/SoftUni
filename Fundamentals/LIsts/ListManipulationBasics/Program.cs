using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] command = Console.ReadLine()
                .Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        AddingMethod(numbers, command[1]);
                        break;
                    case "Remove":
                        RemovingMethod(numbers, command[1]);
                        break;
                    case "RemoveAt":
                        RemovingAtMethod(numbers, command[1]);
                        break;
                    case "Insert":
                        InsertingMethod(numbers, command[1], command[2]);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void InsertingMethod(List<int> numbers, string help, string help2)
        {
            string firstNum = help.ToString();
            string secondNum = help2.ToString();
            numbers.Insert(int.Parse(secondNum), int.Parse(firstNum));
        }

        private static void RemovingAtMethod(List<int> numbers, string help)
        {
            string numInStr = help.ToString();
            numbers.RemoveAt(int.Parse(numInStr));
        }

        private static void RemovingMethod(List<int> numbers, string help)
        {
            string numInStr = help.ToString();
            numbers.Remove(int.Parse(numInStr));
        }

        private static void AddingMethod(List<int> numbers, string help)
        {
            string numInStr = help.ToString();
            numbers.Add(int.Parse(numInStr));
        }
    }
}
