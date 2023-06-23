using System;
using System.Linq;
using System.Xml.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[size][];
            jaggedArray = Reader(jaggedArray);

            for (int i = 0; i < size - 1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i + 1].Length)
                {
                    for (int b = 0; b < jaggedArray[i].Length; b++)
                    {
                        jaggedArray[i][b] *= 2;
                        jaggedArray[i + 1][b] *= 2;
                    }   
                }
                else
                {
                    for (int currentArray = 0; currentArray < jaggedArray[i].Length; currentArray++)
                    {
                        jaggedArray[i][currentArray] /= 2;
                    }

                    for (int nextArray = 0; nextArray < jaggedArray[i + 1].Length; nextArray++)
                    {
                        jaggedArray[i + 1][nextArray] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandInArray = command.Split();
                string action = commandInArray[0];

                switch (action)
                {
                    case "Add":
                    {
                        int row = int.Parse(commandInArray[1]);
                        int col = int.Parse(commandInArray[2]);
                        int value = int.Parse(commandInArray[3]);

                        if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                        {
                            jaggedArray[row][col] += value;
                        }
                    }
                        break;
                    case "Subtract":
                    {
                        int row = int.Parse(commandInArray[1]);
                        int col = int.Parse(commandInArray[2]);
                        int value = int.Parse(commandInArray[3]);

                        if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                        {
                            jaggedArray[row][col] -= value;
                        }
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"{string.Join(" ", jaggedArray[i])}");
            }

        }

        private static int[][] Reader(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            return jaggedArray;
        }
    }
}
