using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double cakePrice =budget * 0.1;
            double sum = 0;

            if (people >= 10 && people <= 15)
            {
                price -= price * 0.15;
                sum = people * price + cakePrice;
            }else if(people > 15 && people <= 20)
            {
                price -= price * 0.2;
                sum = people * price + cakePrice;
            }else if(people > 20)
            {
                price -= price * 0.25;
                sum = people * price + cakePrice;
            }
            else
            {
                sum = people * price + cakePrice;
            }
            if (budget >= sum)
            {
                Console.WriteLine($"It is party time! {(budget - sum):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {(sum - budget):f2} leva needed.");
            }
        }
    }
}
