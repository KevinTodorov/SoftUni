using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string period = Console.ReadLine();
            string contract = Console.ReadLine();
            string anwser = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double price = 0;
            double sum = 0;

            switch (period)
            {
                case "one":
                    switch (contract)
                    {
                        case "Small":
                            price = 9.98;

                            if (anwser == "yes")
                            {
                              price += 5.50;
                            }
                            break;
                        case "Middle":
                            price = 18.99;

                            if (anwser == "yes")
                            {
                                price += 4.35;
                            }
                            break;
                        case "Large":
                            price = 25.98;

                            if (anwser == "yes")
                            {
                                price += 4.35;
                            }
                            break;
                        case "ExtraLarge":
                            price = 35.99;

                            if (anwser == "yes")
                            {
                                price += 3.85;
                            }
                            break;
                    }
                    break;
                case "two":
                    switch (contract)
                    {
                        case "Small":
                            price = 8.58;

                            if (anwser == "yes")
                            {
                                price += 5.50;
                            }
                            break;
                        case "Middle":
                            price = 17.09;

                            if (anwser == "yes")
                            {
                                price += 4.35;
                            }
                            break;
                        case "Large":
                            price = 23.59;

                            if (anwser == "yes")
                            {
                                price += 4.35;
                            }
                            break;
                        case "ExtraLarge":
                            price = 31.79;

                            if (anwser == "yes")
                            {
                                price += 3.85;
                            }
                            break;
                    }
                    break;
            }

            sum = price * months;

            if (period == "two")
            {
                sum -= sum * 0.0375;
            }

            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
