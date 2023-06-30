using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> periods = new SortedDictionary<string, int>();
            string[][] jaggedArray = new string[lines][];

            for (int i = 0; i < lines; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split();
                for (int b = 0; b < jaggedArray[i].Length; b++)
                {
                    string currentPeriod = jaggedArray[i][b];
                    if (!periods.ContainsKey(currentPeriod))
                    {
                        periods.Add(currentPeriod, 1);
                    }
                    else periods[currentPeriod]++;
                }
            }

            foreach (var currPeriod in periods.OrderBy(x => x.Key))
            {
                Console.Write(currPeriod.Key + " ");
            }
        }
    }
}
