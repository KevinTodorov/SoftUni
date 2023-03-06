using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
           
            int clas = 0;
            double gradeSum = 0;
            double exlude = 0;
            while (clas < 12)
            {
                double grades = double.Parse(Console.ReadLine());
                if (grades >= 4)
                {
                    gradeSum += grades;
                    
                }else if (grades < 4)
                {
                    
                    exlude ++;
                }
                if (exlude > 1)
                    break;


                clas++;
            }
            
                if (clas == 12)
                {
                    double average = gradeSum / 12;
                    Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
                }
            else Console.WriteLine($"{name} has been excluded at {clas} grade");
        }
    }
}
