using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();
            int operations = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            List<string> badList = new List<string>();

            for (int i = 0; i < operations; i++)
            {
                string help = Console.ReadLine();
                string[] operation = help.Split();
                bool flag = false;               
                names.Add(operation[0]);

                if (operation.Length == 3)
                {
                    for (int b = 0; b < guestList.Count; b++)
                    {
                        if (names[i] == guestList[b])
                        {
                            flag = true;                           
                        }
                    }
                    if (flag) { Console.WriteLine($"{operation[0]} is already in the list!"); }                                     
                    else { guestList.Add(names[i]); }
                }
                if (operation.Length == 4)
                {
                    for (int j = 0; j < guestList.Count; j++)
                    {
                        if (operation[0] == names[j])
                        {
                            flag = true;                           
                        }
                    }
                    if (flag) { guestList.RemoveAt(guestList.Count - 1); }
                    else { Console.WriteLine($"{operation[0]} is not in the list!"); }
                }
            }
            foreach (var item in guestList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
