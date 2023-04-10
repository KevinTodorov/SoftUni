using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallerNum(0));
        }

        static int SmallerNum(int n)
        {
            int smallestNum = int.MaxValue;

            for (int i = 1; i <= 3; i++)
            {
                 n = int.Parse(Console.ReadLine());

                if (n < smallestNum)
                {
                    smallestNum = n;
                }
            }

            return smallestNum;
        }
    }
}
