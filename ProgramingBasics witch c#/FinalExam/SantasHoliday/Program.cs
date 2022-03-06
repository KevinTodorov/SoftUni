using System;

namespace SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ONEPERSONROOM = 18.00;
            const double APARTMENT = 25.00;
            const double PRESIDENTAPARTMENT = 35.00;

            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;
            double price = 0;

            switch (type)
            {
                case "room for one person":
                    price = nights * ONEPERSONROOM;
                    break;
                case "apartment":
                    price = nights * APARTMENT;
                    if (days < 10)
                    {
                        price -= price * 0.3;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price -= price * 0.35;
                    }
                    else if (days > 15)
                    {
                        price -= price * 0.5;
                    }
                    break;
                case "president apartment":
                    price = nights * PRESIDENTAPARTMENT;
                    if (days < 10)
                    {
                        price -= price * 0.1;
                    }else if(days >= 10 && days <= 15)
                    {
                        price -= price * 0.15;
                    }
                    else if (days > 15)
                    {
                        price -= price * 0.2;
                    }
                    break;
            }
            if (grade == "positive")
            {
                price += price * 0.25;
            }
            else price -= price * 0.1;

            Console.WriteLine($"{price:f2}");

        }
    }
}
