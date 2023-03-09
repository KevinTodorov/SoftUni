using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int curr = 1;
            bool flag = false;

            for (int r = 1; r <= number; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    if(curr > number)
                    {
                        flag = true;
                        break;
                    }
                    if (flag)
                    {
                        break;
                    }
                    Console.Write(curr + " ");
                    curr++;
                }
                Console.WriteLine();
            }
        }
    }
}
