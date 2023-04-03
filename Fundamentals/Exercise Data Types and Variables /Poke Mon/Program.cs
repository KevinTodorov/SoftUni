using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int targetsPoked = 0;
            int nHelp = n;

            while (nHelp >= m)
            {
                nHelp -= m;

                if (nHelp == n * 0.5)
                {
                    nHelp /= y;
                }

                targetsPoked++;
            }
            Console.WriteLine(nHelp);
            Console.WriteLine(targetsPoked);
        }
    }
}
