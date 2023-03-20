using System;

namespace Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int starting = n1 % 10;
            int starting2 = (n1 / 10) % 10;
            int starting3 = (n1 / 100) % 10;
            int starting4 = n1 / 1000;

            int ending = n2 % 10;
            int ending2 = (n2 / 10) % 10;
            int ending3 = (n2 / 100) % 10;
            int ending4 = n2 / 1000;

            for (int i = starting4; i <= ending4; i++)
            {
                for (int z = starting3; z <= ending3; z++)
                {
                    for (int v = starting2; v <= ending2; v++)
                    {
                        for (int b = starting; b <= ending; b++)
                        {
                            if (i % 2 != 0 && z % 2 != 0 && v % 2 != 0 && b % 2 != 0)
                            {
                                Console.Write($"{i}{z}{v}{b} ");
                            }
                        }
                    }
                }
            }
        }
    }
}