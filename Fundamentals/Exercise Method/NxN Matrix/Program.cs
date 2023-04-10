using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NxN_Matrix(number);
        }

        static void NxN_Matrix(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int b = 1; b <= number; b++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
