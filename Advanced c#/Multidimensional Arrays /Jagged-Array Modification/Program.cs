using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int [size][];

            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                jaggedArr[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || row >= size || col < 0 || col >= jaggedArr[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;
                }

                switch (action)
                {
                    case "Add":
                    {
                        jaggedArr[row][col] += value;
                    }
                        break;
                    case "Subtract":
                    {
                        jaggedArr[row][col] -= value;
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{string.Join(" ", jaggedArr[i])}");
            }
        }
    }
}
