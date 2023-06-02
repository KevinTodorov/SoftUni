using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateshipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warshipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maximumHealth = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Retire")
            {
                string[] inputInArr = input.Split();

                switch (inputInArr[0])
                {
                    case "Fire":
                        FireMethod(inputInArr, pirateshipStatus, warshipStatus);
                        break;
                    case "Defend":
                        DefendMethod(inputInArr, pirateshipStatus, warshipStatus);
                        break;
                    case "Repair":
                        RepairMethod(inputInArr, pirateshipStatus, warshipStatus, maximumHealth);
                        break;
                    case "Status":
                        StatusMethod(inputInArr, pirateshipStatus, warshipStatus, maximumHealth);
                        break;
                }
                input = Console.ReadLine();
            }
            int pirateshipHealth = 0;
            int warshipHealth = 0;

            for (int i = 0; i < pirateshipStatus.Count; i++)
            {
                pirateshipHealth += pirateshipStatus[i];
            }

            for (int i = 0; i < warshipStatus.Count; i++)
            {
                warshipHealth += warshipStatus[i];
            }

            Console.WriteLine($"Pirate ship status: {pirateshipHealth}");
            Console.WriteLine($"Warship status: {warshipHealth}");
        }

        private static void DefendMethod(string[] inputInArr, List<int> pirateshipStatus, List<int> warshipStatus)
        {
            int startIndex = int.Parse(inputInArr[1]);
            int endIndex = int.Parse(inputInArr[2]);
            int damage = int.Parse(inputInArr[3]);

            if ((startIndex >= 0 && startIndex <= pirateshipStatus.Count - 1 && startIndex < endIndex) && (endIndex >= 0 && endIndex <= pirateshipStatus.Count - 1 && endIndex > startIndex))
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    if (pirateshipStatus[i] - damage <= 0)
                    {
                        Console.WriteLine("You lost! The pirate ship has sunken.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        pirateshipStatus[i] -= damage;
                    }
                }
            }
        }

        private static void RepairMethod(string[] inputInArr, List<int> pirateshipStatus, List<int> warshipStatus,int maxHp)
        {
            int index = int.Parse(inputInArr[1]);
            int health = int.Parse(inputInArr[2]);

            if (index <= pirateshipStatus.Count - 1 && index >= 0)
            {
                if (pirateshipStatus[index] + health > maxHp)
                {
                    pirateshipStatus[index] = maxHp;
                }
                else
                {
                    pirateshipStatus[index] += health;
                }
            }
        }

        private static void StatusMethod(string[] inputInArr, List<int> pirateshipStatus, List<int> warshipStatus,int maxHp)
        {
            int count = 0;
            double percentsOfMaxHp = 0.2 * maxHp;
            for (int i = 0; i < pirateshipStatus.Count; i++)
            {
                if (pirateshipStatus[i] < percentsOfMaxHp)
                {
                    count++;
                }
            }

            Console.WriteLine($"{count} sections need repair.");
        }

        private static void FireMethod(string[] inputInArr, List<int> pirateshipStatus, List<int> warshipStatus)
        {
            int index = int.Parse(inputInArr[1]);
            int damage = int.Parse(inputInArr[2]);

            if (index <= warshipStatus.Count - 1 && index >= 0)
            {
                if (warshipStatus[index] - damage <= 0)
                {
                    Console.WriteLine("You won! The enemy ship has sunken.");
                    Environment.Exit(0);
                }
                else
                {
                    warshipStatus[index] -= damage;
                }
            }
        }
    }
}
        

