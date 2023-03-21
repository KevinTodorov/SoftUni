using System;

namespace EasternDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            const double BASKETPRICE = 1.50;
            const double WREATHPRICE = 3.80;
            const double CHOCOLATEBUNNY = 7;

            int clients = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;
            double sum = 0;
            double allSum = 0;

            for (int i = 1; i <= clients; i++)
            {
                sum = 0;
                counter = 0;

                while (command != "Finish")
                {
                    switch (command)
                    {
                        case "basket":
                            sum += BASKETPRICE;
                            break;
                        case "wreath":
                            sum += WREATHPRICE;
                            break;
                        case "chocolate bunny":
                            sum += CHOCOLATEBUNNY;
                            break;
                    }
                    counter++;
                    command = Console.ReadLine();
                }
                    if (counter % 2 == 0)
                    {
                        sum -= sum * 0.2;
                    }
                    allSum += sum;
                Console.WriteLine($"You purchased {counter} items for {sum:f2} leva.");
                command = Console.ReadLine();
                
            }
            Console.WriteLine($"Average bill per client is: {(allSum / clients):f2} leva.");
        }
    }
}
