using System;

namespace Easter_Baker
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            double sugarSum = 0;
            double flourSum = 0;
            int maxNumFlour = int.MinValue;
            int maxNumSugar = int.MinValue;
            double sugarPacks = 0;
            double flourPacks = 0;

            for (int i = 1; i <= easterBreads; i++)
            {
            int wastedSugar = int.Parse(Console.ReadLine());
            int wastedFlour = int.Parse(Console.ReadLine());
                if (wastedSugar > maxNumSugar)
                {
                    maxNumSugar = wastedSugar;

                }
                if (wastedFlour > maxNumFlour)
                {
                    maxNumFlour = wastedFlour;
                }
                sugarSum += wastedSugar;
                flourSum += wastedFlour;
            }
            sugarPacks = Math.Ceiling(sugarSum / 950);
            flourPacks = Math.Ceiling(flourSum / 750);
            Console.WriteLine($"Sugar: {sugarPacks}\r\nFlour: {flourPacks}");
            Console.WriteLine($"Max used flour is {maxNumFlour} grams, max used sugar is {maxNumSugar} grams.");

        }
    }
}
