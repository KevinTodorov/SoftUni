using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            long[][] jaggedArr = new long[size][];

            for (int i = 0; i < size; i++)
            {
                long[] row = new long [i + 1];
                row[0] = 1;
                row[i] = 1;
                for (int b = 1; b < i; b++)
                {
                    row[b] = jaggedArr[i - 1][b] + jaggedArr[i - 1][b - 1];
                }

                jaggedArr[i] = row;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{string.Join(" ", jaggedArr[i])}");
            }
        }
    }
}
