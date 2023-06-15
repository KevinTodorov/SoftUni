using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\:{2}|\*{2})(?<emoji>[A-Z]{1}[a-z]{2,})\1";
            double coolTreshhold = 1;
            Dictionary<string, int> emojisList = new Dictionary<string, int>();

            MatchCollection numbersMatches = Regex.Matches(input, @"[0-9]");

            foreach (Match match in numbersMatches)
            {
                coolTreshhold *= double.Parse(match.Value);
            }

            Console.WriteLine($"Cool threshold: {coolTreshhold}");

            MatchCollection emojisMatches = Regex.Matches(input, pattern);

            foreach (Match emojis in emojisMatches)
            {
                string emoji = emojis.Groups["emoji"].Value;
                int emojiCoolnes = 0;
                for (int i = 0; i < emoji.Length; i++)
                {
                    char emojiInChar = (char) emoji[i];
                    int number = emojiInChar;
                    emojiCoolnes += number;
                }
                emojisList.Add(emojis.Value, emojiCoolnes);
            }

            Console.WriteLine($"{emojisList.Count} emojis found in the text. The cool ones are:");
            foreach (var emoji in emojisList.Where(x => x.Value >= coolTreshhold))
            {
                Console.WriteLine($"{emoji.Key}");
            }
        }
    }
}
