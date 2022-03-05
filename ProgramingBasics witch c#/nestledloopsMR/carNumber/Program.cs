using System;

namespace carNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                for (int b = n1; b <= n2; b++)
                {
                    for (int v = n1; v <= n2; v++)
                    {
                        for (int d = n1; d <= n2; d++)
                        {
                            if (i % 2 == 0)
                            {
                                if ((b + v) % 2 == 0)
                                {
                                    if (i > d)
                                    {
                                        if (d % 2 != 0)
                                        {
                                          Console.Write($"{i}{b}{v}{d} ");
                                        }
                                    }
                                }                              
                            }

                            if (i % 2 != 0)
                            {
                                if ((b + v) % 2 == 0)
                                {
                                    if (i > d)
                                    {
                                        if (d % 2 == 0)
                                        {
                                            Console.Write($"{i}{b}{v}{d} ");
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
}
