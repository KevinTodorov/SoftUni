using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;

            switch (typeFlower)
            {
                case "Roses":
                    if (flowers > 80)
                    {
                        price = flowers * 5;
                        discount = price * 0.1;
                        price -= discount;
                    }
                    else price = flowers * 5;
                    break;
                case "Dahlias":
                    if (flowers > 90)
                    {
                        price = flowers * 3.80;
                        discount = price * 0.15;
                        price -= discount;
                    }
                    else price = flowers * 3.80;
                    break;
                case "Tulips":
                    if (flowers > 80)
                    {
                        price = flowers * 2.80;
                        discount = price * 0.15;
                        price -= discount;
                    }
                    else price = flowers * 2.80;
                    break;
                case "Narcissus":
                    if (flowers < 120)
                    {
                        price = flowers * 3;
                        discount = price * 0.15;
                        price += discount;
                    }
                    else price = flowers * 3;
                    break;
                case "Gladiolus":
                    if (flowers < 80)
                    {
                        price = flowers * 2.50;
                        discount = price * 0.2;
                        price += discount;
                    }
                    else price = flowers * 2.50;
                    break;
            }
            if(budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowers} {typeFlower} and {(budget - price):f2} leva left.");
            }
            else Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
        }
    }
}
