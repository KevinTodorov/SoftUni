using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int procesors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            const double vidPrice = 250;
            double videoCard = vidPrice * videocards;
            double procesorsPrice = (videoCard * 0.35) * procesors;
            double ramPrice = (videoCard * 0.1) * ram;
            double finalSum = 0;

            if(videocards > procesors)
            {
                finalSum = videoCard + procesorsPrice + ramPrice;
                finalSum = finalSum - (finalSum * 0.15);
            }else finalSum = finalSum = videoCard + procesorsPrice + ramPrice;

            if(budget >= finalSum)
            {
                Console.WriteLine($"You have {(budget - finalSum):f2} leva left!");
            }
            else Console.WriteLine($"Not enough money! You need {(finalSum - budget):f2} leva more!");


        }
    }
}
