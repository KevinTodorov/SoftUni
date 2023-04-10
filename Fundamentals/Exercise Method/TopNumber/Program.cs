using System;
using System.Linq;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumber(n);
        }

        static void TopNumber(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                string help = i.ToString();
                var helpArr = help.ToCharArray();
                int sum = 0;
                bool flag = false;

                for (int b = 0; b < help.Length; b++)
                {
                    string number = helpArr[b].ToString();
                    int currentNumber = int.Parse(number);

                    if (currentNumber % 2 != 0)
                    {
                        flag = true;
                    }
                    sum += currentNumber;
                }

                if (sum % 8 == 0 && flag)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
