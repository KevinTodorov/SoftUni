using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int allPeople = 0;

            double musala = 0;
            double monblan = 0;
            double killymandjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                allPeople += peopleInGroup;

                if (peopleInGroup <= 5)
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    killymandjaro += peopleInGroup;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }
                else
                {
                    everest += peopleInGroup;
                }

            }

            double musalaPercentage = (musala / allPeople) * 100;
            double munblanPercentage = (monblan / allPeople) * 100;
            double killymandjaroPercentage = (killymandjaro / allPeople) * 100;
            double k2Percentage = (k2 / allPeople) * 100;
            double everestPercentage = (everest / allPeople) * 100;

            Console.WriteLine($"{musalaPercentage:f2}%\r\n{munblanPercentage:f2}%\r\n{killymandjaroPercentage:f2}%\r\n" +
                $"{k2Percentage:f2}%\r\n{everestPercentage:f2}%");

        }
    }
}
