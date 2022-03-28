using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToCharArray();
            Dictionary<char, int> dicitonary = new Dictionary<char, int>();

            foreach (var item in letters)
            {
                if (item != ' ')
                {
                    if (!dicitonary.ContainsKey(item))
                    {
                        dicitonary.Add(item, 0);
                    }

                    dicitonary[item]++;
                }
            }

            foreach (var item in dicitonary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
