using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsAndGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < lines; i++)
            {
                string[] student = Console.ReadLine().Split();
                string studentName = student[0];
                decimal grade = decimal.Parse(student[1]);

                if (!studentsAndGrades.ContainsKey(studentName))
                {
                    studentsAndGrades.Add(studentName, new List<decimal>());
                    studentsAndGrades[studentName].Add(grade);
                }else studentsAndGrades[studentName].Add(grade);
            }

            foreach (var student in studentsAndGrades)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => x.ToString("F2")))} (avg: {student.Value.Average():f2})");
            }

        }
    }
}
