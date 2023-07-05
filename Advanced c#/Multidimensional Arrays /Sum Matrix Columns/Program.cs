using System;
using System.Linq;

namespace Sum_Matrix_Columns
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

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int b = 0; b < matrix.GetLength(0); b++)
                {
                    sum += matrix[b, i];
                }

                Console.WriteLine(sum);
            }
        }

        private static int[] ToArray()
        {
            return Console.ReadLine().Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
