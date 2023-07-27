using System;

namespace Oldest_Family_Member
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];
                int age = int.Parse(command[1]);
                Person newPerson = new Person(name, age);
                family.AddMembers(newPerson);
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }
}
