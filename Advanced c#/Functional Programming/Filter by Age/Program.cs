using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<(string name, int age), int, bool> younger = (person, age) => person.age < age;
            Func<(string name, int age), int, bool> older = (person, age) => person.age >= age;

            List<(string name, int age)> people = new List<(string name, int age)>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);
                people.Add((name, age));
            }

            string condition = Console.ReadLine();
            int filter = int.Parse(Console.ReadLine());
            string[] whatToPrint = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (condition)
                {
                    case "younger":
                    {
                        people = people.Where(x => younger(x, filter)).ToList();
                    }
                        break;
                    case "older":
                    {
                        people = people.Where(x => older(x, filter)).ToList();
                    }
                        break;
                }

                foreach (var peopleTuple in people)
                {
                    List<string> output = new List<string>();

                    if (whatToPrint.Contains("name"))
                    {
                        output.Add(peopleTuple.name);
                    }

                    if (whatToPrint.Contains("age"))
                    {
                        output.Add(peopleTuple.age.ToString());
                    }
                    Console.WriteLine(string.Join(" - ", output));
                }



        }
    }
}
