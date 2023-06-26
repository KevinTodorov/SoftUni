using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            bool partyEnd = false;

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command.Length == 8 && Char.IsDigit(command[0]))
                {
                    vips.Add(command);
                }else if (command.Length == 8 && char.IsLetter(command[0]))
                {
                    regular.Add(command);
                }

                if (command == "PARTY")
                {
                    while (true)
                    {
                        command = Console.ReadLine();

                        if (command == "END")
                        {
                            partyEnd = true;
                            break;
                        }

                        if (vips.Contains(command))
                        {
                            vips.Remove(command);
                        }
                        else regular.Remove(command);
                    }
                }

                if (partyEnd){break;}
                command = Console.ReadLine();
            }

            int sumOfPeopleWhoDidntCome = vips.Count + regular.Count;
            Console.WriteLine(sumOfPeopleWhoDidntCome);

            if (vips.Count > 0)
            {
                foreach (var vip in vips)
                {
                    Console.WriteLine(vip);
                }
            }

            if (regular.Count > 0)
            {
                foreach (var regulars in regular)
                {
                    Console.WriteLine(regulars);
                }
            }
        }
    }
}
