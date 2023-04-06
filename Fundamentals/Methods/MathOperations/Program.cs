using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double help = MathOperationsLogic(int.Parse(Console.ReadLine()), Console.ReadLine(),
                int.Parse(Console.ReadLine()));

            Console.WriteLine(help);
        }

        static double MathOperationsLogic(int a, string operation, int b)
        {
            double sum = 0;

            switch (operation)
            {
                case "/":
                    sum = a / b;
                    break;
                case "*":
                    sum = a * b;
                    break;
                case "+":
                    sum = a + b;
                    break;
                case "-":
                    sum = a - b;
                    break;
            }

            return sum;
        }
    }
}
