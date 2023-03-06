using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
           
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int curr = i;
                int even = 0;
                int odd = 0;
                int count = 0;


                while (curr != 0)
                {
                    int dig = curr % 10;
                    if (count % 2 == 0)
                    {
                        even += dig;
                    }
                    else
                    {
                        odd += dig;
                    }
                    curr /= 10;
                    count++;
                }
                    if(even == odd)
                    {
                        Console.Write(i + " ");
                    }
            }
        }
    }
}
