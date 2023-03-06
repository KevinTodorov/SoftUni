using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0;

            while(input != "NoMoreMoney")
            {
                double Money = double.Parse(input);

                if (Money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                  
                    Console.WriteLine($"Increase: {Money:f2}");
                    total += Money;
                   input = Console.ReadLine();
            }
            
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}