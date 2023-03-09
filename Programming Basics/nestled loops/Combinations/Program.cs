using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int x1 = 0; x1 <= theNumber; x1++)
            {
                for (int x2 = 0; x2 <= theNumber; x2++)
                {
                    for (int x3 = 0; x3 <= theNumber; x3++)
                    {
                        if ((x1 + x2 + x3) == theNumber) 
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
