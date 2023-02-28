using System;

namespace Number_1_with_3_steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i <= number; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
