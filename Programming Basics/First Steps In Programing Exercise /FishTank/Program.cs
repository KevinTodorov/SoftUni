using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int Long = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double Obem = Long * width * height;
            double ObemL = Obem * 0.001;
            double RealPercent = percent / 100;
            double sum = ObemL * (1 - RealPercent);
            Console.WriteLine(sum);

        }
    }
}
