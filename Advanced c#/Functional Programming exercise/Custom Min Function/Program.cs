using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> numFunc = minNum =>
            {
                int smallestNum = int.MaxValue;
                foreach (var num in minNum)
                {
                    if (smallestNum > num)
                    {
                        smallestNum = num;
                    }
                }
                return smallestNum;
            };
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            Console.WriteLine(numFunc(numbers));
        }
    }
}
