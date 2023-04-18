using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Delete":
                        DeleteMethod(numbers, command[1]);
                        break;
                    case "Insert":
                        InsertMethod(numbers, command[2], command[1]);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void InsertMethod(List<int> numbers, string v1, string v2)
        {
            int index = int.Parse(v1);
            int parameter = int.Parse(v2);
            numbers.Insert(index, parameter);
        }

        private static void DeleteMethod(List<int> numbers, string v)
        {
            int element = int.Parse(v);
            numbers.RemoveAll(el => el == element);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == element)
            //    {
            //        numbers.RemoveAt(numbers[i]);
            //    }
            //}
        }
    }
}
