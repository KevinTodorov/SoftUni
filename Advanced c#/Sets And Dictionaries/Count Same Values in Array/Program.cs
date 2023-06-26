using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in arr)
            {
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else numbers[number] += 1;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
