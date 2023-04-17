﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            CheckingMethod(numbers);
        }

        private static void CheckingMethod(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
