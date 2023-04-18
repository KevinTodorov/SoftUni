using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "3:1")
            {
                switch (command[0])
                {
                    case "merge":
                        MergeMethod(input, command[1], command[2]);
                        break;
                    case "divide":
                        DivideMethod(input, command[1], command[2]);
                        break;
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", input));
        }

        private static void MergeMethod(List<string> input, string v1, string v2)
        {
            int startIndex = int.Parse(v1);
            int endIndex = int.Parse(v2);

            for (int i = 1; i <= endIndex; i++)
            {
               if (i < 0 || startIndex  + i > input.Count - 1 || startIndex  + i < 0)
               {
                 break;
               }
                else
                {
                    input[startIndex] += input[startIndex + i];
                    input.RemoveAt(startIndex + i);                   
                }	
            }
        }

        private static void DivideMethod(List<string> input, string v1, string v2)
        {
            int index = int.Parse(v1);
            int lenght = int.Parse(v2);
            int number = input[index].Length;
            int substract = number / lenght;
            int indexSubstracter = 0;
            int indexCount = index;
            bool flag = false;

            if (substract % 2 != 0)
            {
                flag = true;
            }

            for (int i = 0; i < lenght; i++)
            {
                string help = input[index + i].ToString();
                string letter = string.Empty;
                int count = 0;

                while (count != substract)
                {
                    letter += help[indexSubstracter];

                    indexSubstracter++;
                    count++;
                }
                
                indexCount++;

                if (flag)
                {
                    if (i == lenght - 1)
                    {
                        letter += help[indexSubstracter];
                    }
                }               

                input.Insert(indexCount, letter);
            }
            input.RemoveAt(indexCount);
        }
    }
}
