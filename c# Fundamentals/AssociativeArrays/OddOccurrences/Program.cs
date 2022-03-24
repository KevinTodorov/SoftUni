using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();

            Dictionary<string, int> dicitionary = new Dictionary<string, int>();

            for (int i = 0; i < elements.Count; i++)
            {
                string word = elements[i].ToLower();
                if (!dicitionary.ContainsKey(word))
                {
                    dicitionary.Add(word, 0);
                }

                dicitionary[word]++;
            }

            foreach (var item in dicitionary)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key.ToLower() + " ");
                }
            }
        }
    }
}
