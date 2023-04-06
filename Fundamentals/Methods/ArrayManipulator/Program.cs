using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] word = Console.ReadLine().Split();
            while (word[0] != "end")
            {
                if (word[0] == "exchange")
                {
                    array = Exchange(array, word);
                }
                else if (word[0] == "max" || word[0] == "min")
                {
                    MinAndMax(array, word[0], word[1]);
                }
                else
                {
                    FindNumbers(array, word[0], int.Parse(word[1]), word[2]);
                }
                word = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        static void FindNumbers(int[] array, string v1, int v2, string v3)
        {
            if (v2 > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (v2 == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            int resultEvenOdd = 1;
            if (v3 == "even")
            {
                resultEvenOdd = 0;
            }
            int count = 0;
            List<int> nums = new List<int>();

            if (v1 == "first")
            {
                foreach (var item in array)
                {
                    if (item % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(item);
                    }
                    if (count == v2)
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(array[i]);
                    }
                    if (count == v2)
                    {
                        break;
                    }
                }
                nums.Reverse();
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        static void MinAndMax(int[] currNum, string minOrMax, string evenOrOdd)
        {
            int index = -1;
            int min = int.MaxValue;
            int max = int.MinValue;

            int result = 1;

            if (evenOrOdd == "even")
            {
                result = 0;
            }

            for (int i = 0; i < currNum.Length; i++)
            {
                if (currNum[i] % 2 == result)
                {
                    if (minOrMax == "min" && min >= currNum[i])
                    {
                        min = currNum[i];
                        index = i;
                    }
                    else if (minOrMax == "max" && max <= currNum[i])
                    {
                        max = currNum[i];
                        index = i;
                    }
                }
            }
            if (index > -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static int[] Exchange(int[] currNum, string[] command)
        {
            int splitIndex = int.Parse(command[1]) + 1;

            int[] exchangedArray = new int[currNum.Length];
            int count = 0;

            if (splitIndex > currNum.Length || int.Parse(command[1]) < 0)
            {
                Console.WriteLine("Invalid index");
                return currNum;
            }


            for (int i = splitIndex; i < currNum.Length; i++)
            {
                exchangedArray[count] = currNum[i];
                count++;
            }

            for (int i = 0; i < splitIndex; i++)
            {
                exchangedArray[count] = currNum[i];
                count++;
            }

            return exchangedArray;
        }

        
    }
}
