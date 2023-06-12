using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([#@])(?<word>[A-Za-z]{3,})\1{2}(?<secondword>[A-Za-z]{3,})\1");
            MatchCollection matches = regex.Matches(input);
            List<string> list = new List<string>();

            for (int i = 0; i < matches.Count; i++)
            {
                    string currentWord = matches[i].Groups["word"].Value;
                    string nextWord = matches[i].Groups["secondword"].Value;
                    string reversedWord = string.Empty;
                    for (int b = nextWord.Length - 1; b >= 0; b--)
                    {
                        reversedWord += nextWord[b];
                    }
                    if (currentWord == reversedWord)
                    {
                        list.Add($"{currentWord} <=> {nextWord}");
                    }
            }

            int count = matches.Count;

            if (count > 0)
            {
                Console.WriteLine($"{count} word pairs found!");
            }else Console.WriteLine("No word pairs found!");

            if (list.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine($"{string.Join(", ", list)}");
            }else Console.WriteLine("No mirror words!");
            
        }
    }
}
