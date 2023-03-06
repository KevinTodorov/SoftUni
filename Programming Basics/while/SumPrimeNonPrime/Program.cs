using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumOfPrimeNumbers = 0;
            int sumOfNonPrimeNumbers = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);
                int counter = 0;

                for (int i = 1; i <= number; i++)
                {
                    if(number % i == 0)
                    {
                        counter++;
                    }
                }
                    if(number < 0)
                    {
                        Console.WriteLine("Number is negative.");
                       number = 0;
                    
                    }
                    if(counter == 2)
                    {
                        sumOfPrimeNumbers += number;
                    }
                    else
                    {
                        sumOfNonPrimeNumbers += number;
                    }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNumbers}");
            
        }
    }
}
