using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> destinations = new List<string>();
            MatchCollection matches = Regex.Matches(input, @"(\=|\/){1}(?<name>[A-Z][a-zA-Z]{2,})\1");

            int travelPoints = 0;
            foreach (Match match in matches)
            {
                string destination = match.Groups["name"].Value;
                travelPoints += destination.Length;
                destinations.Add(destination);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
