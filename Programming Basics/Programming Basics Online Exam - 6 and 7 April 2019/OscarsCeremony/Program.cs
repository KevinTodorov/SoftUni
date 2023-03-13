using System;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallPrice = double.Parse(Console.ReadLine());

            double statuesPrice = hallPrice - (hallPrice * 0.3);
            double servicePrice = statuesPrice - (statuesPrice * 0.15);
            double sounding = servicePrice - (servicePrice * 0.5);

            double sum = statuesPrice + servicePrice + sounding + hallPrice;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
