using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] reading = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[i, b] = reading[b];
                }
            }

            int count = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int b = 0; b < matrix.GetLength(1) - 1; b++)
                {
                    if (matrix[i, b] == matrix[i, b + 1] && matrix[i + 1, b] == matrix[i + 1, b + 1] && matrix[i, b] == matrix[i + 1, b])
                    {
                        count ++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
