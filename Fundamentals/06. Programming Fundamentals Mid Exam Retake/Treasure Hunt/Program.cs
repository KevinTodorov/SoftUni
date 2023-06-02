using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lootList = Console.ReadLine().Split("|").ToList();
            string input = Console.ReadLine();

            while (input != "Yohoho!")
            {
                string[] inputInArr = input.Split();

                switch (inputInArr[0])
                {
                    case "Loot":
                        LootMethod(inputInArr, lootList);
                        break;
                    case "Drop":
                        DropMethod(inputInArr, lootList);
                        break;
                    case "Steal":
                        StealMethod(inputInArr, lootList);
                        break;
                }

                input = Console.ReadLine();
            }

            double lenghtOfItems = 0;
            for (int i = 0; i < lootList.Count; i++)
            {
                int currentItemLenght = lootList[i].Length;
                lenghtOfItems += currentItemLenght;
            }

            double averageTreasureGain = lenghtOfItems / lootList.Count;

            if (lootList.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageTreasureGain:f2} pirate credits.");
            }else Console.WriteLine("Failed treasure hunt.");
        }

        private static void LootMethod(string[] inputInArr, List<string> lootList)
        {
            for (int i = 1; i < inputInArr.Length; i++)
            {
                string currentItem = inputInArr[i];
                if (!lootList.Contains(currentItem))
                {
                    lootList.Insert(0, currentItem);
                }
            }
        }

        private static void DropMethod(string[] inputInArr, List<string> lootList)
        {
            int index = int.Parse(inputInArr[1]);

            if (index <= lootList.Count - 1 && index >= 0 )
            {
                string temp = lootList[index];
                lootList.RemoveAt(index);
                lootList.Add(temp);
            }
        }

        private static void StealMethod(string[] inputInArr, List<string> lootList)
        {
            int count = int.Parse(inputInArr[1]);
            List<string> stolenItems = new List<string>();

            for (int i = lootList.Count - 1; i >= 0; i--)
            {
                stolenItems.Add(lootList[i]);
                lootList.RemoveAt(i);
                if (stolenItems.Count == count)
                {
                    break;
                }
            }

            stolenItems.Reverse();
            Console.WriteLine($"{string.Join(", ", stolenItems)}");
        }
    }
}
