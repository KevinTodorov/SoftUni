using System;
using System.Collections.Generic;

namespace Student_Academy
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, double> studentdsAndGrades = new Dictionary<string, double>();
            Dictionary<string, int> studentsAndGradeCounter = new Dictionary<string, int>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentdsAndGrades.ContainsKey(name))
                {
                    studentdsAndGrades.Add(name, 0);
                    studentsAndGradeCounter.Add(name, 0);
                }

                studentdsAndGrades[name] += grade;
                studentsAndGradeCounter[name]++;
            }

            foreach (var grades in studentdsAndGrades)
            {
                foreach (var item in studentsAndGradeCounter)
                {
                    if (grades.Key == item.Key)
                    {
                        if (grades.Value / item.Value >= 4.50)
                        {
                            Console.WriteLine($"{grades.Key} -> {grades.Value / item.Value:f2}");
                        }
                    }
                }
            }
        }
    }
}
