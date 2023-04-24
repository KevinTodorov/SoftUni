using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Identification> identifications = new List<Identification>();

            while (input != "End")
            {
                string[] inputInArray = input.Split();
                string name = inputInArray[0];
                string id = inputInArray[1];
                int age = int.Parse(inputInArray[2]);
                Identification identification = new Identification();
                identification.Name = name;
                identification.Id = id;
                identification.Age = age;
                bool flag = false;

                for (int i = 0; i < identifications.Count; i++)
                {
                    if (id == identifications[i].Id )
                    {
                        identifications[i].Age = age;
                        identifications[i].Name = name;
                        flag = true;
                    }
                }

                if (!flag)
                {
                    identifications.Add(identification);
                }

                input = Console.ReadLine();
            }
            identifications = identifications.OrderByDescending(s => s.Age).ToList();
            identifications.Reverse();
            foreach (Identification identity in identifications)
            {
                Console.WriteLine($"{identity.Name} with ID: {identity.Id} is {identity.Age} " +
                                  $"years old.");
            }
        }
    }

    class Identification
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

    }
}
