using System;

namespace Left_And_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            for(int i = 0; i < times * 2;i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(i < times)
                {
                    left += number;
                }else
               
                {
                    right += number;
                }

            }
                if(left == right)
                {
                    Console.WriteLine($"Yes, sum = {right}");
                }
                else
                {
                    Console.WriteLine($"No, diff = {Math.Abs(left - right)}");
                }
        }
    }
}
