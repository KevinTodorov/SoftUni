using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int notTouchedN = n;

            int all = 0;

            string count = n.ToString();
            int lenght = count.Length;

            for (int i = 1; i <= lenght; i++)
            {          
                int sum = 1;
                int n2 = n % 10;
                n /= 10;

                for (int b = 1; b <= n2; b++)
                {
                    sum *= b;
                }

                all += sum;
            }

            if (all == notTouchedN)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
