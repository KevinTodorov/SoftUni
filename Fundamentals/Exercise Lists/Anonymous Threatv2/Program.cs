using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threatv2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (true)
            {
                string[] array = command.Split();
                if (command == "3:1")
                {
                    break;
                }

                if (array[0] == "merge")
                {
                    MergeMethod(input, array[1], array[2]);
                }
                else if (array[0] == "divide")
                {
                    DivideMethod(input, array[1], array[2]);
                }


                command = Console.ReadLine();
            }
            foreach (var item in input)
            {
                Console.Write($"{item} ");
            }

        }

        private static void MergeMethod(List<string> input, string v1, string v2)
        {
            int startIndex = int.Parse(v1);
            int endIndex = int.Parse(v2);

            for (int i = startIndex; i < endIndex; i++)
            {
                if (startIndex + 1 < input.Count)
                {
                    input[startIndex] += input[i + 1];
                    input.RemoveAt(i + 1);
                    i--;
                }
                else break;
            }
        }

        private static void DivideMethod(List<string> input, string v1, string v2)
        {
            int index = int.Parse(v1);
            int partitions = int.Parse(v2);
            int substractPartitions = input[index].Length / partitions;
            string word = input[index].ToString();
            string help = string.Empty;
            int indexHelp = 0;
            int count = index;
            int currentCount = 1;

            for (int i = 0; i < word.Length; i++)
            {
                 help += word[i];

                if (substractPartitions % 2 != 0)
                {
                    if (currentCount == substractPartitions)
                    {
                        if (i == word.Length - 2)
                        {
                            help += word[i + 1];
                            i++;
                        }
                        input.Insert(index + indexHelp, help);
                        help = string.Empty;
                        indexHelp++;
                        count++;
                        currentCount = 0;                       
                    }
                }
                else
                {
                    if (currentCount == substractPartitions)
                    {
                        input.Insert(index + indexHelp, help);
                        help = string.Empty;
                        count++;
                        indexHelp++;
                        currentCount = 0;
                    }
                }
                currentCount++;
             
            }
            input.RemoveAt(count);
        }
    }
}
