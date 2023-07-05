using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] arr = ToArray();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[i, b] = arr[b];
                }
            }

            int maxSum = int.MinValue;
            int row = 0;
            int col = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int b = 0; b < matrix.GetLength(1) - 1; b++)
                {
                    int sum = matrix[i, b] + matrix[i, b + 1] + matrix[i + 1, b] + matrix[i + 1, b + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        row = i;
                        col = b;
                    }
                }
            }

            Console.WriteLine($"{matrix[row, col]} {matrix[row, col + 1]}\r\n{matrix[row + 1, col]} {matrix[row + 1, col + 1]}\r\n{maxSum}");
        }
        private static int[] ToArray()
        {
            return Console.ReadLine().Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
