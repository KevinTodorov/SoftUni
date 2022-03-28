using System;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesData = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split(" : ");
                string course = input[0];
                string student = input[1];

                if (!coursesData.ContainsKey(course))
                {
                    coursesData.Add(course, new List<string>());
                }
                coursesData[course].Add(student);

                command = Console.ReadLine();
            }

            foreach (var item in coursesData)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var names in item.Value)
                {
                    Console.Write($"-- {names}");
                    Console.WriteLine();
                }
            }
        }
    }
}
