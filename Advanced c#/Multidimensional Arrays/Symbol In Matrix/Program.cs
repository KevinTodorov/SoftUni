using System;
using System.Text;

namespace Symbol_In_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string word = Console.ReadLine();
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    int ascii = word[b];
                    matrix[i, b] = ascii;
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            int asciiSymbol = symbol;
            bool flag = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    if (matrix[i, b] == asciiSymbol)
                    {
                        Console.WriteLine($"({i}, {b})");
                        return;
                    }
                    else flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
