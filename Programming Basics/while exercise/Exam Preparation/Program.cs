using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int badGradesCounter = 0;
            int counterProblems = 0;
            string lastName = "";
            double average = 0;

            while(command != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if(grade <= 4)
                {
                    badGradesCounter++;
                }
                if(badGradesCounter == badGrades)
                {
                    Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                    return;
                }
                counterProblems++;
                average += grade;
                lastName = command;
                command = Console.ReadLine();
            }
            Console.WriteLine($"Average score: {(average / counterProblems):f2}\r\nNumber of problems: {counterProblems}\r\nLast problem: {lastName}");
        }
    }
}
