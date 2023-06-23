using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                int[] reading = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[i, b] = reading[b];
                }
            }

            int primarySum = 0;
            int secondarySum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int b = i; b < i + 1; b++)
                {
                    primarySum += matrix[i, b];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int b = matrix.GetLength(1) - 1 - i; b > matrix.GetLength(1) - i - 2; b--)
                {
                    secondarySum += matrix[i, b];
                }
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
