using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split(" -> ");
                string companyName = input[0];
                string id = input[1];

                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                }

                if (company.ContainsKey(companyName) && !company[companyName].Contains(id))
                {
                    company[companyName].Add(id);
                }

                command = Console.ReadLine();
            }

            foreach (var workers in company)
            {
                Console.WriteLine($"{workers.Key}");

                foreach (var ids in workers.Value)
                {
                    Console.WriteLine($"-- {string.Join(" ", ids)}");
                }
            }
        }
    }
}
