using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double toyPrice = int.Parse(Console.ReadLine());
            int toys = 0;
            double savedMoney = 0;
            double sum = 0;

            for(int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    savedMoney += ((i / 2.0) * 10.0) - 1;
                }
                else
                {
                    toys += 1;
                }
                
            }
            sum = (savedMoney + (toys * toyPrice));
            if(sum >= price)
            {
                Console.WriteLine($"Yes! {(sum - price):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(price - sum):f2}");
            }
        }
    }
}
