using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for(int y = firstNumber; y <= secondNumber; y++)
                {
                        counter++;
                    if(i + y == finalNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {y} = {i + y})");
                        return;
                    }


                }
            }
                  Console.WriteLine($"{counter} combinations - neither equals {finalNumber}");
            
        }
    }
}
