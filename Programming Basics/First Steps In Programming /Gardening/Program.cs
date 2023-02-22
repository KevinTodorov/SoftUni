using System;

namespace Gardening
{
    class Program
    {
        static void Main(string[] args)
        {
            double Meters = double.Parse(Console.ReadLine());
            double price = Meters * 7.61;
            double discount = 0.18 * price;
            double FinalPrice = price - discount;

            Console.WriteLine("The final price is: " + FinalPrice + " lv.");
            Console.WriteLine("The discount is: " + discount + " lv.");
        }
    }
}
