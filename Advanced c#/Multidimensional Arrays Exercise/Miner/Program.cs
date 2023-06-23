using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            string[] moves = Console.ReadLine().Split();
            matrix = ReadingMethod(matrix);
          
            int rowIndex = 0;
            int colIndex = 0;

            int allCoals = 0;
            foreach (var letter in matrix)
            {
                if (letter == 'c')
                {
                    allCoals++;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    if (matrix[i, b] == 's')
                    {
                        rowIndex = i;
                        colIndex = b;
                    }
                }
            }

            for (int i = 0; i < moves.Length; i++)
            {
                string currentMove = moves[i];

                switch (currentMove)
                {
                    case "up":
                    {
                        if (IsValidUp(matrix, rowIndex, colIndex))
                        {
                            rowIndex -= 1;
                            if (matrix[rowIndex, colIndex] == 'e')
                            {
                                Console.WriteLine($"Game over! ({rowIndex + 1}, {colIndex})");
                                return; 
                            }else if (matrix[rowIndex, colIndex] == 'c')
                            {
                                allCoals--;
                                if (allCoals == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({rowIndex},             {colIndex})");
                                    return;
                                }
                                matrix[rowIndex, colIndex] = '*';
                            }
                        }
                    }
                        break;
                    case "right":
                    {
                        if (IsValidRight(matrix, rowIndex, colIndex))
                        {
                            if (matrix[rowIndex, colIndex + 1] == 'e')
                            {
                                Console.WriteLine($"Game over! ({rowIndex}, {colIndex + 1})");
                                return;
                            }
                            else if (matrix[rowIndex, colIndex + 1] == 'c')
                            {
                                allCoals--;
                                if (allCoals == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({rowIndex},             {colIndex})");
                                    return;
                                }
                                matrix[rowIndex, colIndex + 1] = '*';
                            }
                            colIndex += 1;
                        }
                    }
                        break;
                    case "left":
                    {
                        if (IsValidLeft(matrix, rowIndex, colIndex))
                        {
                            colIndex -= 1;
                            if (matrix[rowIndex, colIndex] == 'e')
                            {
                                Console.WriteLine($"Game over!({rowIndex}, {colIndex})");
                                return;
                            }else if (matrix[rowIndex, colIndex] == 'c')
                            {
                                allCoals--;
                                if (allCoals == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({rowIndex},             {colIndex})");
                                    return;
                                }
                                matrix[rowIndex, colIndex] = '*';
                            }
                        }
                    }
                        break;
                    case "down":
                    {
                        if (IsValidDown(matrix, rowIndex, colIndex))
                        {
                            rowIndex += 1;
                            if (matrix[rowIndex, colIndex] == 'e')
                            {
                                Console.WriteLine($"Game over!({rowIndex}, {colIndex})");
                                return;
                            }
                            else if (matrix[rowIndex, colIndex] == 'c')
                            {
                                allCoals--;
                                if (allCoals == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({rowIndex},             {colIndex})");
                                    return;
                                }
                                matrix[rowIndex, colIndex] = '*';
                            }
                        }
                    }
                        break;
                }
            }
            Console.WriteLine($"{allCoals} coals left. ({rowIndex}, {colIndex})");
        }

        private static bool IsValidDown(char[,] matrix, int rowIndex, int colIndex)
        {
            if ( rowIndex + 1 < matrix.GetLength(0))
            {
                return true;
            }
            else return false;
        }

        private static bool IsValidLeft(char[,] matrix, int rowIndex, int colIndex)
        {
            if (colIndex - 1 < matrix.GetLength(1))
            {
                return true;
            }
            else return false;
        }

        private static bool IsValidRight(char[,] matrix, int rowIndex, int colIndex)
        {
            if (colIndex + 1 < matrix.GetLength(1))
            {
                return true;
            }
            else return false;
        }

        private static bool IsValidUp(char[,] matrix, int rowIndex, int colIndex)
        {
            if (rowIndex - 1 < matrix.GetLength(0))
            {
                return true;
            }
            else return false;
        }


        private static char[,] ReadingMethod(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] temp = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    matrix[i, b] = temp[b];
                }
            }
            return matrix;
        }
    }
}
