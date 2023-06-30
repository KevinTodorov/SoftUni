using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPass = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                string[] commandInArr = command.Split(":");
                if (!contestAndPass.ContainsKey(commandInArr[0]))
                {
                    contestAndPass.Add(commandInArr[0], commandInArr[1]);
                }
                command = Console.ReadLine();
            }

            string input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] inputInArr = input.Split(new string[]{":", "=", ">"}, StringSplitOptions.RemoveEmptyEntries);
                string contest = inputInArr[0];
                string password = inputInArr[1];
                string nameOfStudent = inputInArr[2];
                int points = int.Parse(inputInArr[3]);

                if (ContestIsValid(contest, password, contestAndPass))
                {
                    if (!students.ContainsKey(nameOfStudent))
                    {
                        students.Add(nameOfStudent, new Dictionary<string, int>());
                        students[nameOfStudent].Add(contest, points);
                    }else if (!students[nameOfStudent].ContainsKey(contest))
                    {
                        students[nameOfStudent].Add(contest, points);
                    }else if (students[nameOfStudent].ContainsKey(contest))
                    {
                        if (students[nameOfStudent][contest] < points)
                        {
                            students[nameOfStudent][contest] = points;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            int maxPoints = int.MinValue;
            string name = String.Empty;
            foreach (var student in students)
            {
                int studentPoints = 0;
                foreach (var item in student.Value)
                {
                    studentPoints += item.Value;
                }

                if (studentPoints > maxPoints)
                {
                    maxPoints = studentPoints;
                    name = student.Key;
                }
            }

            Console.WriteLine($"Best candidate is {name} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key}");
                foreach (var item in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }

        private static bool ContestIsValid(string contest, string password, Dictionary<string, string> contestAndPass)
        {
            foreach (var contes in contestAndPass)
            {
                if (contes.Key == contest && contes.Value == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
