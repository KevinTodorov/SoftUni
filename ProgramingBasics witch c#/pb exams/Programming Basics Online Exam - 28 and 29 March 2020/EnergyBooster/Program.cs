using System;

namespace EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int boughtSets = int.Parse(Console.ReadLine());

            double sum = 0;

            switch (fruit)
            {
                case "Watermelon":
                    if (size == "small")
                    {
                        sum = 56 * 2 *boughtSets;
                    }else if(size == "big")
                    {
                        sum = 28.70 * 5 * boughtSets;
                    }
                    break;
                case "Mango":
                    if (size == "small")
                    {
                        sum = 36.6 * 2 * boughtSets;
                    }
                    else if (size == "big")
                    {
                        sum = 19.60 * 5 * boughtSets;
                    }
                    break;
                case "Pineapple":
                    if (size == "small")
                    {
                        sum = 42.10 * 2 * boughtSets;
                    }
                    else if (size == "big")
                    {
                        sum = 24.80 * 5 * boughtSets;
                    }
                    break;
                case "Raspberry":
                    if (size == "small")
                    {
                        sum = 20 * 2 * boughtSets;
                    }
                    else if (size == "big")
                    {
                        sum = 15.20 * 5 * boughtSets;
                    }
                    break;
            }
            if (sum >= 400 && sum <= 1000)
            {
                sum -= sum * 0.15;
            }else if(sum > 1000)
            {
                sum -= sum * 0.5;
            }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
