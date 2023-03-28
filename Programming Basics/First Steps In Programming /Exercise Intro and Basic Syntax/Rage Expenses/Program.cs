using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double singleHeadsetPrice = double.Parse(Console.ReadLine());
            double singleMousePrice = double.Parse(Console.ReadLine());
            double singleKeyboardPrice = double.Parse(Console.ReadLine());
            double singleDisplayPrice = double.Parse(Console.ReadLine());

            int count = 0;
            int brokenHeadsetCounter = 0;
            int brokenMouseCounter = 0;
            int brokenKeyboardCounter = 0;
            int brokenDispayCounter = 0;

            double sum = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {

                if (count % 2 == 0 && count != 0)
                {
                    brokenHeadsetCounter += 1;
                    sum += singleHeadsetPrice;
                }

                if (count % 3 == 0 && count != 0)
                {
                    brokenMouseCounter += 1;
                    sum += singleMousePrice;
                }

                if (count %  6 == 0 && count != 0)
                {
                    brokenKeyboardCounter += 1;
                    sum += singleKeyboardPrice;

                    if (count % 12 == 0)
                    {
                        brokenDispayCounter++;
                        sum += singleDisplayPrice;
                    }
                }
                count++;
            }
         
            Console.WriteLine($"{sum:f2}");

        }
    }
}
