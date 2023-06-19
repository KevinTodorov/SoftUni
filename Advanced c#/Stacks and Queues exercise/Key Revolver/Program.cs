using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] numberOfBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numberOfLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(numberOfBullets);
            Queue<int> locks = new Queue<int>(numberOfLocks);

            bool runOutOfBullets = false;
            bool runOutOfLocks = false;
            int shootedBullets = 0;
            int barrelCounter = 0;

            while (true)
            {
                int round = 0;
                int lockPower = 0;

                if (barrelCounter == sizeOfGunBarrel)
                {
                    barrelCounter = 0;
                    if (bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        continue;
                    }
                    else
                    {
                        runOutOfBullets = true;
                        break;
                    }
                }
                if (locks.Count <= 0)
                {
                    runOutOfLocks = true;
                    break;
                }
                if (bullets.Count <= 0)
                {
                    runOutOfBullets = true;
                    break;
                }
                round = bullets.Pop();
                shootedBullets++;
                barrelCounter++;
                lockPower = locks.Peek();
                if (round <= lockPower)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }else Console.WriteLine("Ping!");
            }

            if (bullets.Count == 0 && locks.Count == 0)
            {
                int spentMoney = shootedBullets * priceOfBullet;
                int leftMoney = valueOfIntelligence - spentMoney;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${leftMoney}");
                return;
            }

            if (runOutOfBullets)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                return;
            }

            if (runOutOfLocks)
            {
                int spentMoney = shootedBullets * priceOfBullet;
                int leftMoney = valueOfIntelligence - spentMoney;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${leftMoney}");
                return;
            }
        }
    }
}
