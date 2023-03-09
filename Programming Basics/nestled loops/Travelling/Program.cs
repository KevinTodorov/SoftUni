using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string country= Console.ReadLine();

            while(country != "End")
            {
                double price = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while(savedMoney < price)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }
                Console.WriteLine($"Going to {country}!");
                country = Console.ReadLine();
            }
        }
    }
}
