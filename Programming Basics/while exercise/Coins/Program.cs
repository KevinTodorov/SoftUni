using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double coins = money * 100;
            int cents = (int) coins;
            int counter = 0;

            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    counter += 1;
                    cents -= 200;
                } else if (cents - 100 >= 0)
                {
                    counter += 1;
                    cents -= 100;
                } else if (cents - 50 >= 0)
                {
                    counter += 1;
                    cents -= 50;
                } else if (cents - 20 >= 0)
                {
                    counter += 1;
                    cents -= 20;
                } else if (cents - 10 >= 0)
                {
                    counter += 1;
                    cents -= 10;
                } else if (cents - 5 >= 0)
                {
                    counter += 1;
                    cents -= 5;
                }else if (cents - 2 >= 0)
                {
                    counter += 1;
                    cents -= 2;
                }else if (cents - 1 >= 0)
                {
                    counter += 1;
                    cents -= 1;
                }
            }
                    Console.WriteLine(counter);
                   

            
        }
    }
}
