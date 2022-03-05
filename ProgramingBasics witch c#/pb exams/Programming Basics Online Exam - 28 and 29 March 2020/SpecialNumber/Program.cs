using System;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int z = 1; z <= n; z++)
                {
                    for (int b = 1; b <= n; b++)
                    {
                        for (int c = 1; c <= n; c++)
                        {
                            if (i > 9)
                            {
                                break;
                            }
                            if (z > 9)
                            {
                                break;
                            }
                            if (b > 9)
                            {
                                break;
                            }
                            if (c > 9)
                            {
                                c = 1;
                                break;
                            }

                            if (n % i == 0 && n % z == 0 && n % b == 0 && n % c == 0 )
                            {
                                Console.Write($"{i}{z}{b}{c} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
