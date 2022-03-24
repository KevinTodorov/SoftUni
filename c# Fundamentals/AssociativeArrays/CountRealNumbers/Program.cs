using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> arr = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, double> dicitonary = new SortedDictionary<double, double>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (!dicitonary.ContainsKey(arr[i]))
                {
                    dicitonary.Add(arr[i], 0);
                }

                dicitonary[arr[i]]++;
            }

            

            foreach (var item in dicitonary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
