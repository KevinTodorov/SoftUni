using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            List<int> numList = new List<int>();
            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                numList.Add(i);
            }


            Predicate<string> numPredicate = s =>
            {
                if (s == "odd")
                {
                    return true;
                }
                else return false;
            };

            if (numPredicate(command))
            {
                foreach (var num in numList.Where(x => x % 2 != 0))
                {
                    Console.Write(num + " ");
                }
            }
            else
            { 
                foreach (var num in numList.Where(x => x % 2 == 0))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
