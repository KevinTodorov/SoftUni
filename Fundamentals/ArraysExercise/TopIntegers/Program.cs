using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < number.Length; i++)
            {

                bool flag = false;

                for (int b = i + 1; b < number.Length;  b++)
                {
                    if (number[i] >= number[b])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }

                if (flag)
                {
                    Console.Write(number[i] + " ");
                }
            }
            Console.Write(number[number.Length - 1]);
        }
    }
}
