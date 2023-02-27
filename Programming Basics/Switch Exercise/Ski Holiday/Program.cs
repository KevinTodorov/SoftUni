using System;

namespace Ski_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ROOMFORONE = 18.00;
            const double APARTMENT = 25.00;
            const double PRESIDENT = 35.00;
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();
            double sum = 0;

            switch (room)
            {
                case "room for one person":
                    days -= 1;
                        sum = days * ROOMFORONE;
                    break;
                case "apartment":
                    if(days < 10)
                    {
                        days -= 1;
                        sum = days * APARTMENT;
                        sum = sum - (sum * 0.3);
                    }else if(days >= 10 && days <= 15)
                    {
                        days -= 1;
                        sum = days * APARTMENT;
                        sum = sum - (sum * 0.35);
                    }else if(days > 15)
                    {
                        days -= 1;
                        sum = days * APARTMENT;
                        sum = sum - (sum * 0.5);
                    }
                    break;
                case "president apartment":
                    if(days < 10)
                    {
                        days -= 1;
                        sum = days * PRESIDENT;
                        sum = sum - (sum * 0.1);
                    }else if(days >= 10 && days <= 15)
                    {
                        days -= 1;
                        sum = days * PRESIDENT;
                        sum = sum - (sum * 0.15);
                    }else if(days > 15)
                    {
                        days -= 1;
                        sum = days * PRESIDENT;
                        sum = sum - (sum * 0.2);
                    }
                    break;
                    
            }
            if (feedback == "positive")
            {
                sum = sum + (sum * 0.25);
                Console.WriteLine($"{sum:f2}");
            }
            else if (feedback == "negative")
            {
                sum = sum - (sum * 0.1);
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}
                       
                    
