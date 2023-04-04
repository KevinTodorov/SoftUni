using System;
using System.Linq;

namespace Lady_Bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] ladybugs = new int[size];
            string numbers = Console.ReadLine();
            string command = Console.ReadLine();

            int[] initialField = new int[size];

            int[] help = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < help.Length; i++)
            {
                initialField[i] = 1;
            }           

            ladybugs = numbers.Split().
                Select(int.Parse).
                ToArray();

            string[] flyLentgh = new string[3];


            while (command != "end")
            {
                flyLentgh = command.Split();
                int firstHelp = int.Parse(flyLentgh[0]);
                int secondHelp = int.Parse(flyLentgh[2]);

                bool flag = false;
                switch (flyLentgh[1])
                {
                    case "right":

                        if (firstHelp + secondHelp > initialField.Length - 1)
                        {
                            flag = true;
                        }

                        if (flag)
                        {
                            initialField[firstHelp] = 0;
                            initialField[initialField.Length - 1] = 0;
                            break;
                        }

                        if (initialField[firstHelp] == 1 || initialField[firstHelp] == 0)
                        {
                            if (initialField[firstHelp + secondHelp] == 1)
                            {
                                if (firstHelp + secondHelp + 1 > initialField.Length - 1)
                                {
                                    initialField[initialField.Length - 1] = 0;
                                    initialField[firstHelp] = 0;
                                    break;
                                }

                                initialField[firstHelp + secondHelp + 1] = 1;
                                initialField[firstHelp] = 0;
                            }
                            else
                            {
                                initialField[firstHelp] = 0;
                                initialField[firstHelp + secondHelp] = 1;
                            }
                        }
                        break;
                    case "left":
                        if (firstHelp - secondHelp < 0)
                        {
                            flag = true;
                        }
                        if (flag)
                        {
                            initialField[firstHelp] = 0;
                            initialField[initialField.Length - 1] = 0;
                            break;
                        }

                        if (initialField[firstHelp] == 1 || initialField[firstHelp] == 1)
                        {
                            if (initialField[firstHelp - secondHelp] == 1)
                            {
                                if (firstHelp - secondHelp - 1 > initialField.Length - 1)
                                {
                                    initialField[firstHelp - secondHelp - 1] = 0;
                                    initialField[firstHelp] = 0;
                                    break;
                                }
                                initialField[firstHelp - secondHelp - 1] = 1;
                                initialField[firstHelp] = 0;
                            }                         
                            else
                            {
                                initialField[firstHelp] = 0;
                                initialField[firstHelp - secondHelp] = 1;
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.Write(String.Join(" ", initialField));
        }
    }
}
