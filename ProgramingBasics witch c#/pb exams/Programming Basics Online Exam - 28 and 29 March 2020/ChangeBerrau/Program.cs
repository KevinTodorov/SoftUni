using System;

namespace ChangeBerrau
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double chinesecoin = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double bitcoinToBgn = bitcoin * 1168;
            double chinesecoinToUsd = chinesecoin * 0.15;
            double chinesecoinToBgn = chinesecoinToUsd * 1.76;
            double everythingToEuro = (bitcoinToBgn + chinesecoinToBgn) / 1.95;

            double comissionPrice = everythingToEuro * (comission / 100);

            double afterComissionEuro = everythingToEuro - comissionPrice;

            Console.WriteLine($"{afterComissionEuro:f2}");
        }
    }
}
