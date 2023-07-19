using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var numbers = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                numbers.Add(i);
            }

            foreach (var divider in dividers)
            {
                Func<int, bool> filterFunc = x => x % divider == 0;

                numbers = numbers.Where(filterFunc).ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
