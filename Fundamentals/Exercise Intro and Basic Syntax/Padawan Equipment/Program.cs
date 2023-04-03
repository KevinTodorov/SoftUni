using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double singleLightsaberPrice = double.Parse(Console.ReadLine());
            double singleRobePrice = double.Parse(Console.ReadLine());
            double singleBeltPrice = double.Parse(Console.ReadLine());

            double price = 0;
            double disc = Math.Ceiling((double)students / 6);

            double robesPrice = singleRobePrice * students;
            double fix = Math.Ceiling(students + (students * 0.1));
            double lightsabersPrice = singleLightsaberPrice * fix;

            if (disc >= 1)
            {
                students -= (int)disc;
            }

            double beltsPrice = singleBeltPrice * students;

            price = robesPrice + beltsPrice + lightsabersPrice;

            if (price <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {price - budget:f2} more.");
            }
        }
    }
}
