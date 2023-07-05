using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[i, b] = arr[b];
                    sum += arr[b];
                }
            }

            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(sum);
        }

    }
}
