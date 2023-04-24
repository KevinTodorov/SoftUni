using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Students
    {
        public string firstname_;
        public string lastname_;
        public double grade_;
        public Students(string firstname, string lastname, double grade)
        {
            FirstName = firstname;
            LastName = lastname;
            Grade = grade;
        }

        public string FirstName 
        { 
            get => firstname_;
            set => firstname_ = value;
        }

        public string LastName
        {
            get => lastname_;
            set => lastname_ = value;
        }

        public double Grade
        {
            get => grade_;
            set => grade_ = value;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Grade}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> student = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Students students = new Students(firstName, lastName, grade);
               student.Add(students);
            }

            student = student.OrderByDescending(s => s.Grade).ToList();
            foreach (Students stud in student)
            {
                Console.WriteLine($"{stud.FirstName} {stud.LastName}: {stud.Grade:f2}");
            }
        }
    }
}
