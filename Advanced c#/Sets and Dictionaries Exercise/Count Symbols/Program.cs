using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> textData = new SortedDictionary<char, int>();

            textData = PuttingDataInDictionary(textData, input);

            foreach (var text in textData)
            {
                Console.WriteLine($"{text.Key}: {text.Value} time/s");   
            }
        }

        private static SortedDictionary<char, int> PuttingDataInDictionary(SortedDictionary<char, int> textData, string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];

                if (!textData.ContainsKey(currentLetter))
                {
                    textData.Add(currentLetter, 1);
                }
                else textData[currentLetter]++;
            }
            return textData;
        }
    }
}
