using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1111; i <= 9999; i++)
            {
                int curr = i;
                int counter = 0;
                int c = 1;
               while(c <= 4)
                {
                    
                    int digit = curr % 10;
                    if (n % digit == 0 && digit != 0)
                    {
                        counter++;
                    }
                    curr /= 10;
                    c++;
                }
                if(counter == 4)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
