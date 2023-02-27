using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double income = 0;

            switch (type)
            {
                case "Premiere":
                    income = (r * c) * 12.00;
                    break;
                case "Normal":
                    income = (r * c) * 7.50;
                    break;
                case "Discount":
                    income = (r * c) * 5.00;
                    break;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
