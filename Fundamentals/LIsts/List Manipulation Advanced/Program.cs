using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();
                string[] command = Console.ReadLine()
                    .Split();
                bool flag = false;

                while (command[0] != "end")
                {
                    switch (command[0])
                    {
                        case "Add":
                            AddingMethod(numbers, command[1]);
                            flag = true;
                            break;
                        case "Remove":
                            RemovingMethod(numbers, command[1]);
                            flag = true;
                            break;
                        case "RemoveAt":
                            RemovingAtMethod(numbers, command[1]);
                            flag = true;
                            break;
                        case "Insert":
                            InsertingMethod(numbers, command[1], command[2]);
                            flag = true;
                            break;
                        case "Contains":
                            ContainsMethod(numbers, command[1]);
                            break;
                        case "PrintEven":
                            PrintEvenSumMethod(numbers);
                            break;
                        case "PrindOdd":
                            PrintOddSumMethod(numbers);
                            break;
                        case "GetSum":
                            GetSumMethod(numbers);
                            break;
                        case "Filter":
                            FilterMethod(command[1], command[2], numbers);
                            break;
                    }
                    command = Console.ReadLine().Split();
                }
                if (flag) { Console.WriteLine(string.Join(" ", numbers)); }

            }


        }
        static void InsertingMethod(List<int> numbers, string help, string help2)
            {
                string firstNum = help.ToString();
                string secondNum = help2.ToString();
                numbers.Insert(int.Parse(secondNum), int.Parse(firstNum));
            }

        static void RemovingAtMethod(List<int> numbers, string help)
            {
                string numInStr = help.ToString();
                numbers.RemoveAt(int.Parse(numInStr));
            }

        static void RemovingMethod(List<int> numbers, string help)
            {
                string numInStr = help.ToString();
                numbers.Remove(int.Parse(numInStr));
            }

        static void AddingMethod(List<int> numbers, string help)
            {
                string numInStr = help.ToString();
                numbers.Add(int.Parse(numInStr));
            }

        static void FilterMethod(string v1, string v2, List<int> numbers)
        {
            switch (v1)
            {
                case "<":
                    List<int> lowerNumbers = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < int.Parse(v2))
                        {
                            lowerNumbers.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", lowerNumbers));
                    break;
                case ">":
                    List<int> biggerNumbers = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > int.Parse(v2))
                        {
                            biggerNumbers.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", biggerNumbers));
                    break;
                case ">=":
                    List<int> biggerOrEqualNumbers = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= int.Parse(v2))
                        {
                            biggerOrEqualNumbers.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", biggerOrEqualNumbers));
                    break;
                case "<=":
                    List<int> smallerOrEqualNumbers = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= int.Parse(v2))
                        {
                            smallerOrEqualNumbers.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", smallerOrEqualNumbers));
                    break;
            }
        }

        static void GetSumMethod(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        static void PrintOddSumMethod(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintEvenSumMethod(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", evenNumbers));
        }

        static void ContainsMethod(List<int> numbers, string v)
        {
            if (numbers.Contains(int.Parse(v))) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No such number"); }                      
        }
    }
}
