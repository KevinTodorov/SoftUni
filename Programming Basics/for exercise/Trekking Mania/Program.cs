using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double Musala = 0;
            double Monblan = 0;
            double Kilimandjaro = 0;
            double K2 = 0;
            double Everest = 0;
            int sum = 0;

            for(int i = 1; i <= groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sum += people;
                if(people <= 5)
                {
                    Musala += people;
                }else if(people >= 6 && people <= 12)
                {
                    Monblan += people;
                }else if(people >= 13 && people <= 25)
                {
                    Kilimandjaro += people;
                }else if(people >= 26 && people <= 40)
                {
                    K2 += people;
                }else if(people >= 41)
                {
                    Everest += people;
                }
            }
            double percentMusala = Musala / sum * 100;
            double percentMonblan = Monblan / sum * 100;
            double percentKilimandjaro = Kilimandjaro / sum * 100;
            double percentK2 = K2 / sum * 100;
            double percentEverest = Everest / sum * 100;
            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKilimandjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
        }
    }
}
