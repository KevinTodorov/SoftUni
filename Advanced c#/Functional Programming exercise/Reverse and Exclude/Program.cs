using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            Stack<int> numberStack = new Stack<int>(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numberStack.Pop();
            }
            List<int> oddNumbers = new List<int>();
            int numberToDivide = int.Parse(Console.ReadLine());

            Predicate<int> predicate = number =>
            {
                if (number % numberToDivide != 0)
                {
                    return true;
                }
                else return false;
            };

            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    oddNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", oddNumbers));
        }
    }
}
