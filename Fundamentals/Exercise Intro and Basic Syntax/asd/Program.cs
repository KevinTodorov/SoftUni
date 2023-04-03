using System;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int lostGames = int.Parse(Console.ReadLine());
            double headsettPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            //VARIABLES
            int counter = 0;
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            double totalPrice = 0;

            for (int i = 0; i < lostGames; i++)
            {
                if (counter % 2 == 0 && counter != 0)
                {
                    headsetCount++;
                    totalPrice += headsettPrice;
                }
                if (counter % 3 == 0 && counter != 0)
                {
                    mouseCount++;
                    totalPrice += mousePrice;
                }
                if (counter % 6 == 0 && counter != 0)
                {
                    keyboardCount++;
                    totalPrice += keyboardPrice;

                    if (counter % 12 == 0)
                    {
                        displayCount++;
                        totalPrice += displayPrice;
                    }
                }
                counter++;
            }
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}
