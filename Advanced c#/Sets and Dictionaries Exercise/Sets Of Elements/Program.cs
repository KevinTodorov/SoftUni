using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfLines = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> counter = new Dictionary<int, int>();

            for (int i = 0; i < numberOfLines[0]; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (!counter.ContainsKey(currNumber))
                {
                    counter.Add(currNumber, 1);
                }
            }

            for (int i = 0; i < numberOfLines[1]; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (!counter.ContainsKey(currNumber))
                {
                    counter.Add(currNumber, 1);
                }
                else counter[currNumber]++;
            }

            foreach (var number in counter.Where(x => x.Value > 1))
            {
                Console.Write(number.Key + " ");
            }

        }
    }
}
