using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cakeprice = 0.2 * rent;
            double drinksprice = cakeprice - (cakeprice * 0.45);
            double animatorprice = (1.00/3.00) * rent;
            double sum = cakeprice + drinksprice + animatorprice + rent;

            Console.WriteLine(1.00/3.00);
            Console.WriteLine($"{sum:f1}");

        }
    }
}
