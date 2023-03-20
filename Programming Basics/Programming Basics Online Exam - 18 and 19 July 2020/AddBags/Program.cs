using System;

namespace AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggagePrice = double.Parse(Console.ReadLine());
            double luggageKg = double.Parse(Console.ReadLine());
            int daysOfTravelling = int.Parse(Console.ReadLine());
            int luggages = int.Parse(Console.ReadLine());

            if (luggageKg <= 10)
            {
                luggagePrice = luggagePrice * 0.2;
            }
            else if (luggageKg > 10 && luggageKg <= 20)
            {
                luggagePrice = luggagePrice * 0.5;
            }
            else if(luggageKg > 20)
            {
                luggagePrice = luggagePrice;
            }

            if (daysOfTravelling > 30)
            {
                luggagePrice += luggagePrice * 0.1;
            }else if(daysOfTravelling >= 7 && daysOfTravelling <= 30)
            {
                luggagePrice += luggagePrice * 0.15;
            }else if (daysOfTravelling < 7)
            {
                luggagePrice += luggagePrice * 0.4;
            }
            Console.WriteLine($"The total price of bags is: {(luggagePrice * luggages):f2} lv.");
        }
    }
}
