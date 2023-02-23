using System;

namespace repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double NylonPrice = (nylon + 2) * 1.50;
            double PaintPrice = (paint + (paint / 10 )) * 14.50;
            double ThinnerPrice = thinner * 5.00;
            double price = NylonPrice + PaintPrice  + ThinnerPrice + 0.40;
            double WorkersSalary = (price * 30 / 100) * hours;
            double sum = price + WorkersSalary;
            Console.WriteLine(sum);
        }
    }
}
