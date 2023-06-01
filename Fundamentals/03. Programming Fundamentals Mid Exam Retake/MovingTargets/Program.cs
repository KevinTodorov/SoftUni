using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTargets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] array = command.Split();
                int index = int.Parse(array[1]);
                int value = int.Parse(array[2]);

                switch (array[0])
                {
                    case "Shoot":
                        ShootMethod(targets, index, value);
                        break;
                    case "Add":
                        AddMethod(targets, index, value);
                        break;
                    case "Strike":
                        StrikeMethod(targets, index, value);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.Write($"{string.Join("|", targets)} ");
        }

        private static void ShootMethod(List<int> targets, int index, int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= value;

                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
        }

        private static void AddMethod(List<int> targets, int index, int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        private static void StrikeMethod(List<int> targets, int index, int value)
        {
            bool flagLeft = false;
            bool flagRight = false;
            if (index >= 0 && index < targets.Count)
            {
                if (index - value >= 0 && index - value < index)
                {
                    flagLeft = true;
                }
                if (index + value > index && index + value < targets.Count)
                {
                    flagRight = true;
                }
            }
            if (flagRight && flagLeft)
            {
                List<int> help = new List<int>();
                int indexTarget = targets[index];
                for (int i = value; i > 0; i--)
                {
                    help.Add(targets[index - i]);
                    help.Add(targets[index + i]);
                }

                for (int i = 0; i < help.Count; i++)
                {
                    targets.Remove(help[i]);
                }
                targets.Remove(indexTarget);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
        }
    }
}
