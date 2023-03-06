using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            while(n >= num)
            {
                num = num * 2 + 1;
                if(num > n)
                {
                    break;
                }
                Console.WriteLine(num);
            }
        }
    }
}
