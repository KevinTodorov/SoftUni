using System;
using System.Numerics;

namespace BigFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Factoriel numberForFactoriel = new Factoriel();
            numberForFactoriel.number = int.Parse(Console.ReadLine());
            numberForFactoriel.Factor();;
        }

    }
    class Factoriel
    {
        private BigInteger numberAfterFactoriel = 1;

        public int number { get; set; }

        public void Factor()
        {
            for (int i = 1; i <= number; i++)
            {
                numberAfterFactoriel *= i;
            }

            Console.WriteLine(numberAfterFactoriel);
        }
    }
}
