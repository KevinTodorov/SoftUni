using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] arr = ToArray();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[i, b] = arr[b];
                }
            }

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int b = i; b < i + 1; b++)
                {
                    sum += matrix[i, b];
                }
            }

            Console.WriteLine(sum);
        }
        private static int[] ToArray()
        {
            return Console.ReadLine().Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }

    }
}
