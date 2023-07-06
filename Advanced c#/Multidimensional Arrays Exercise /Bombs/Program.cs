using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            matrix = ReadingMatrix(matrix);
            string[] bombs = Console.ReadLine().Split();

            for (int i = 0; i < bombs.Length; i++)
            {
                string bomb = bombs[i];
                int row = int.Parse(bomb[0].ToString());
                int col = int.Parse(bomb[2].ToString());
                int explodingPower = matrix[row, col];

                for (int b = row; b < row + 1; b++)
                {
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        if (matrix[b, c] > 0)
                        {
                            matrix[b, c] -= explodingPower;
                        }
                    }
                }

                int leftLentghDownDiagonal = matrix.GetLength(0) - (row + 1);
                if (leftLentghDownDiagonal > 0)
                {
                    int currentCol = col;
                    for (int b = row + 1; b < matrix.GetLength(0); b++)
                    {
                        if (currentCol - 1 >= 0)
                        {
                            currentCol--;
                            if (matrix[b, currentCol] > 0)
                            {
                                matrix[b, currentCol] -= explodingPower;
                            }
                        }
                    }
                }

                if (row > 0 && col < matrix.GetLength(1) - 1)
                {
                    int currRow = row;
                    int currCol = col;

                    while (true)
                    {
                        if (currRow - 1 >= 0 && currCol + 1 < matrix.GetLength(1))
                        {
                            currRow--;
                            currCol++;
                            if (matrix[currRow, currCol] > 0)
                            {
                                matrix[currRow, currCol] -= explodingPower;
                            }
                        }
                        else break;
                    }
                }

                if (row > 0)
                {

                    for (int c = row - 1; c >= 0; c--)
                    {
                        if (matrix[c, col] > 0)
                        {
                            matrix[c, col] -= explodingPower;
                        }
                    }
                }
                for (int b = row + 1; b < matrix.GetLength(0); b++)
                {
                    if (matrix[b, col] > 0)
                    {
                        matrix[b, col] -= explodingPower;
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    Console.Write($"{matrix[i,b]} ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] ReadingMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] readingHelp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[i, b] = readingHelp[b];
                }
            }

            return matrix;
        }
    }
}
