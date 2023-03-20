using System;

namespace AddBagsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            double lugage = double.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double lugages = double.Parse(Console.ReadLine());
            double price = 0;
            double dayPrice = 0;
            double sum = 0;

            if (kg < 10)
            {
                price = lugage * 0.2;
            }
            else if (kg >= 10 && kg <= 20)
            {
                price = lugage * 0.5;
            }
            else price = lugage;

            if (days > 30)
            {
                dayPrice = price * 0.1;
            }
            else if (days >= 7 && days <= 30)
            {
                dayPrice = price * 0.15;
            }
            else dayPrice = price * 0.4;

            sum = (dayPrice + price) * lugages;
            Console.WriteLine($"The total price of bags is: {sum:f2} lv.");
        }
    }
}
