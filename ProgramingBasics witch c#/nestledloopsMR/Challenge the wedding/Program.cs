using System;

namespace Challenge_the_wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int mens = int.Parse(Console.ReadLine());
            int womens = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int menCounter = mens;
           
                for (int i = 1; i <= mens; i++)
                {
                    for (int b = 1; b <= womens; b++)
                    {
                        Console.Write($"({i} <-> {b}) ");
                        tables -= 1;

                        if (tables == 0)
                        {
                            return;
                        }
                    }                                   
                }

            }
        }
    }

