using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            matrix = ReadingMatrix(matrix);
            int sum = int.MinValue;
            int col = 0;
            int row = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int b = 0; b < matrix.GetLength(1) - 2; b++)
                {
                    int firstRowSum = matrix[i, b] + matrix[i, b + 1] + matrix[i, b + 2];
                    int secondRowSum = matrix[i + 1, b] + matrix[i + 1, b + 1] + matrix[i + 1, b + 2];
                    int thirdRowSum = matrix[i + 2, b] + matrix[i + 2, b + 1] + matrix[i + 2, b + 2];
                    int allSummed = firstRowSum + secondRowSum + thirdRowSum;
                    if (allSummed > sum)
                    {
                        sum = allSummed;
                        row = i;
                        col = b;
                    } 
                }
            }

            Console.WriteLine($"Sum = {sum}");
            for (int i = row; i < row + 3; i++)
            {
                for (int b = col; b < col + 3; b++)
                {
                    Console.Write(matrix[i, b] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] ReadingMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] read = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[i, b] = read[b];
                }
            }

            return matrix;
        }
    }
}
