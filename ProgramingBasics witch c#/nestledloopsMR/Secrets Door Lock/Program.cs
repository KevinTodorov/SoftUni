using System;

namespace Secrets_Door_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n1; i++)
            {
                for (int b = 1; b <= n2; b++)
                {
                    for (int d = 1; d <= n3; d++)
                    {
                        if (i % 2 == 0 && d % 2 == 0)
                        {
                            if (b == 2 || b == 3 || b == 5 || b == 7)
                            {
                                Console.WriteLine($"{i} {b} {d} ");
                            }
                        }
                    }
                }
            }

        }
    }
}
