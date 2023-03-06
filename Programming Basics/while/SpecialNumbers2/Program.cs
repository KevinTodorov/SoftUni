using System;

namespace SpecialNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 9; i++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    for (int s = 1; s <= 9; s++)
                    {
                        for (int b = 1; b <= 9; b++)
                        {
                            if(n % i == 0 && n % c == 0 && n % s == 0 && n % b == 0)
                            {
                                Console.Write($"{i}{c}{s}{b} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
