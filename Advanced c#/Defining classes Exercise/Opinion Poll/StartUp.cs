using System;
using System.Linq;

namespace Opinion_Poll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var persons = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                int age = int.Parse(command[1]);
                persons[i] = new Person(command[0], age);
            }

            persons = persons.OrderBy(n => n.Name).ToArray();

            foreach (Person member in persons.Where(a => a.Age > 30))
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
