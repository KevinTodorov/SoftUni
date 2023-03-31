using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = people / capacity;
            int coursesV2 = people % capacity;

            if (people % capacity == 0)
            {
                Console.WriteLine(courses);
                return;
            }
            if (coursesV2 <= capacity && coursesV2 != 0)
            {
                coursesV2 = 1;
                Console.WriteLine(courses + coursesV2);
                return;
            }

            
        }
    }
}
