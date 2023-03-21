using System;

namespace Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            double cakeKg = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double coockiesKg = double.Parse(Console.ReadLine());
            

            double cakePrice = cakeKg * 3.20;
            double eggsPrice = eggs * 4.35;
            double coockiesPrice = coockiesKg * 5.40;
            double eggsPaint = eggs * 12 * 0.15;
            Console.WriteLine($"{(cakePrice + eggsPrice + coockiesPrice + eggsPaint):f2}");
        }
    }
}
