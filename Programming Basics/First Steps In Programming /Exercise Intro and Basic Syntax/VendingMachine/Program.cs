using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;

            while(command != "Start")
            {

                double coins = double.Parse(command);
                sum += coins;

                if (coins != 2 && coins != 1 && coins != 0.5 && coins != 0.2 && coins != 0.1)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    sum -= coins;
                }
                command = Console.ReadLine();
            }

            string input = Console.ReadLine();

            while (input != "End")
            {

                switch (input)
                {
                    case "Nuts":
                        if (sum - 2 >= 0)
                        {
                            Console.WriteLine("Purchased nuts");
                            sum -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sum - 0.7 >= 0)
                        {
                            Console.WriteLine("Purchased water");
                            sum -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (sum - 1.5 >= 0)
                        {
                            Console.WriteLine("Purchased crisps");
                            sum -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (sum - 0.8 >= 0)
                        {
                            Console.WriteLine("Purchased soda");
                            sum -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sum - 1 >= 0)
                        {
                            Console.WriteLine("Purchased coke");
                            sum -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                            break;

                }
                        input = Console.ReadLine();
            }
                Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
