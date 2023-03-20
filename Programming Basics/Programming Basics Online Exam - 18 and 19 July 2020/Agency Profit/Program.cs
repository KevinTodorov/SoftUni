using System;

namespace Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            String company = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double adultTicketsPrice = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double kidTIcketsPrice = adultTicketsPrice - (adultTicketsPrice * 0.7);
            double adultPrice = adultTicketsPrice + tax;
            double kidPrice = kidTIcketsPrice + tax;
            double sum = (adultTickets * adultPrice) + (kidPrice * kidTickets);
            Console.WriteLine($"The profit of your agency from {company} tickets is {(0.2 * sum):f2} lv.") ;
        }
    }
}
