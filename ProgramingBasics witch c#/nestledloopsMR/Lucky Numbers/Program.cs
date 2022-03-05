using System;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int v = 1; v <= 9; v++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (i + j == v + d)
                            {
                                if (n % (i + j) == 0)
                                {
                                    Console.Write($"{i}{j}{v}{d} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
