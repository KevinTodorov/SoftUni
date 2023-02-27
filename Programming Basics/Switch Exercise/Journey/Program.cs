using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double sum = 0;

            if(money <= 100)
            {
                switch (season)
                {
                    case "summer":
                        sum = money * 0.3;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {sum:f2}");
                        break;
                    case "winter":
                        sum =money * 0.7;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {sum:f2}");
                        break;
                }
                
            }else if(money <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        sum = money * 0.4;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine($"Camp - {sum:f2}");
                        break;
                    case "winter":
                        sum =money * 0.8;
                        Console.WriteLine($"Somewhere in Balkans");
                           Console.WriteLine($"Hotel - {sum:f2}");
                        break;
                }
            }else if(money > 1000)
            {
                sum =money * 0.9;
                Console.WriteLine($"Somewhere in Europe");
                Console.WriteLine($"Hotel - {sum:f2}");
            }
        }
    }
}
