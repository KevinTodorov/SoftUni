using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                        if((N1 + N2) % 2 == 0) 
                        {
                            Console.WriteLine($"{N1} + {N2} = {N1 + N2} - even");
                        }
                    else Console.WriteLine($"{N1} + {N2} = {N1 + N2} - odd");
                    break;
                case "-":
                    if((N1 - N2) % 2 == 0)
                    {
                        Console.WriteLine($"{N1} - {N2} = {N1 - N2} - even");
                    }
                    else Console.WriteLine($"{N1} - {N2} = {N1 - N2} - odd");
                    break;
                case "*":
                    if ((N1 * N2) % 2 == 0)
                    {
                        Console.WriteLine($"{N1} * {N2} = {N1 * N2} - even");
                    }
                    else Console.WriteLine($"{N1} * {N2} = {N1 * N2} - odd");
                    break;
                case "/":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else if (N2 != 0)
                    {
                        double n1 = N1;
                        double n2 = N2;
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                    }
                    break;
                case "%":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");


                    } else if(N2 != 0)
                    {
                        Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
                    }
                    break;


                    
            }
        }
    }
}
