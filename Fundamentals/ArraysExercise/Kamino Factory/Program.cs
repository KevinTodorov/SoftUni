using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            int[] number = new int[dnaLength];

            string command = Console.ReadLine();

            int bestSum = 0;
            int bestLength = 1;
            int bestStartingIndex = 1;
            int bestCounter = 0;
            int counter = 0;

            int[] bestNumber = new int[dnaLength];

            while (command != "Clone them!")
            {
                int[] currentNumber = command.Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int length = 1;
                int bestCurrLength = 1;
                int startingCurrIndex = 1;
                int currSum = 0;
                counter++;

                for (int i = 0; i < currentNumber.Length - 1; i++)
                {
                    if (currentNumber[i] == currentNumber[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }

                    if (length > bestCurrLength)
                    {
                        bestCurrLength = length;
                        startingCurrIndex = i;
                    }

                    currSum += currentNumber[i];
                }
                currSum += currentNumber[dnaLength - 1];

                if (bestCurrLength > bestLength)
                {
                    bestLength = bestCurrLength;
                    bestStartingIndex = startingCurrIndex;
                    bestCounter = counter;
                    bestSum = currSum;
                    bestNumber = currentNumber.ToArray();
                }

                if (bestCurrLength == bestLength)
                {
                    if (startingCurrIndex < bestStartingIndex)
                    {
                        bestLength = bestCurrLength;
                        bestStartingIndex = startingCurrIndex;
                        bestCounter = counter;
                        bestSum = currSum;
                        bestNumber = currentNumber;
                    }
                    else if (startingCurrIndex == bestStartingIndex)
                    {
                        if (currSum > bestSum)
                        {
                            bestLength = bestCurrLength;
                            bestStartingIndex = startingCurrIndex;
                            bestCounter = counter;
                            bestSum = currSum;
                            bestNumber = currentNumber;
                        }
                    }
                }


                command = Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.Write($"{String.Join(" ", bestNumber)}");

        }
    }
}
