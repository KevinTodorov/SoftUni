using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            matrix = ReadingMethod(matrix);

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    return;
                }

                if (command[0] == "swap" && command.Length == 5 && int.Parse(command[1]) < matrix.GetLength(0) &&
                    int.Parse(command[2]) < matrix.GetLength(1))
                {
                    int firstRow = int.Parse(command[1]);
                    int firstCol = int.Parse(command[2]);
                    int secondRow = int.Parse(command[3]);
                    int secondCol = int.Parse(command[4]);

                    string temp = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = temp;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int b = 0; b < matrix.GetLength(1); b++) 
                        {
                            Console.Write(matrix[i, b] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else Console.WriteLine("Invalid input!");
            }
        }

        private static string[,] ReadingMethod(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] read = Console.ReadLine().Split();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[i, b] = read[b];
                }
            }

            return matrix;
        }
    }
}
