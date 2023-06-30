using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            wardrobe = PuttingDataIntoDictionary(lines, wardrobe);

            string[] searchedCloth = Console.ReadLine().Split();

            foreach (var clothes in wardrobe)
            {
                Console.WriteLine($"{clothes.Key} clothes:");
                foreach (var cloth in clothes.Value)
                {
                    if (searchedCloth[0] == clothes.Key && searchedCloth[1] == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }

        private static Dictionary<string, Dictionary<string, int>> PuttingDataIntoDictionary(int lines, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] colourAndClothes = Console.ReadLine().Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries);
                string clothesColour = colourAndClothes[0];

                if (!wardrobe.ContainsKey(clothesColour))
                {
                    wardrobe.Add(clothesColour, new Dictionary<string, int>());
                }

                for (int b = 1; b < colourAndClothes.Length; b++)
                {
                    string currCloth = colourAndClothes[b];

                    if (!wardrobe[clothesColour].ContainsKey(currCloth))
                    {
                        wardrobe[clothesColour].Add(currCloth, 1);
                    }
                    else wardrobe[clothesColour][currCloth]++;
                }
            }
            return wardrobe;
        }
    }
}
