using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Butique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            int racks = 1; 
            int valueOfClothes = 0;

            Stack<int> stack = new Stack<int>(items);

            while (stack.Count > 0)
            {
                if (valueOfClothes + stack.Peek() == capacityOfRack)
                {
                    racks++;
                    valueOfClothes = 0;
                    stack.Pop();
                }else if (valueOfClothes + stack.Peek() > capacityOfRack)
                {
                    racks++;
                    valueOfClothes = 0;
                }
                else valueOfClothes += stack.Pop();
            }

            Console.WriteLine(racks);
        }
    }
}
