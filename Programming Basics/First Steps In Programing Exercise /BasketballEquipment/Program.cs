using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int Price = int.Parse(Console.ReadLine());
            double KicksPrice = Price - (Price * 0.4);
            double ClothesPrice = KicksPrice - (KicksPrice * 0.2);
            double BallPrice = ClothesPrice * 0.25;
            double Accesoriess = BallPrice * 0.2;

            double sum = Price + KicksPrice + BallPrice + ClothesPrice + Accesoriess;
            Console.WriteLine(sum);
        }
    }
}
