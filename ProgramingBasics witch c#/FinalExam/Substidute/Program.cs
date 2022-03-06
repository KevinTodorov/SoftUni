using System;

namespace Substidute
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = n1; i <= 8; i++)
            {
                for (int b = 9; b >= n2; b--)
                {
                    for (int c = n3; c <= 8; c++)
                    {
                        for (int v = 9; v >= n4; v--)
                        {

                            if (i % 2 == 0 && b % 2 != 0 && c % 2 == 0 & v % 2 != 0)
                            {
                                if (i == c && b == v)
                                {
                                    Console.WriteLine($"Cannot change the same player.");
                                }else
                                {
                                    Console.WriteLine($"{i}{b} - {c}{v}");
                                   counter++;
                                   if (counter == 6)
                                   {
                                     return;
                                   }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
