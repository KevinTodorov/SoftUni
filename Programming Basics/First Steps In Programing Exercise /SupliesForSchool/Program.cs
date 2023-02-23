using System;

namespace SupliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int litres = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double PenPrice = pens * 5.80;
            double MarkersPrice = markers * 7.20;
            double LitresPrice = litres * 1.20;
            double sum = PenPrice + MarkersPrice + LitresPrice;
            double SumAfterDiscount = sum - (sum * (discount / 100));
            Console.WriteLine(SumAfterDiscount);

        }
    }
}
