using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            
            double allGrades = 0;
            double counter = 0;

            while(name != "Finish")
            {
                double averageGrade = 0;
                for (int numberOfGrades = 1; numberOfGrades <= judges; numberOfGrades++)
                {
                    counter++;
                  double grade = double.Parse(Console.ReadLine());
                    allGrades += grade;
                    averageGrade += grade;
                }
                Console.WriteLine($"{name} - {(averageGrade / judges):f2}.");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(allGrades / counter):f2}.");
        }
    }
}

                

