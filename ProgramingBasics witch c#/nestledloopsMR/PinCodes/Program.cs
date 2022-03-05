using System;

namespace PinCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int h = 1; h <= b; h++)
                {
                    for (int j = 1; j <= c; j++)
                    {
                        if (i % 2 == 0 && j % 2 == 0 && (h >= 2 && h != 4 && h <= 7 && h != 6))
                        {
                            Console.WriteLine($"{i} {h} {j}");
                        }
                    }
                }
            }
        }
    }
}
