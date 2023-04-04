using System;
using System.Linq;

namespace LadyBugsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] ladyBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] initialFields = new int[fieldSize];

            for (int i = 0; i < ladyBugs.Length; i++)
            {
                if (ladyBugs[i] >= 0 && ladyBugs[i] <= initialFields.Length - 1)
                {
                    initialFields[ladyBugs[i]] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] help = command.Split();
                int ladybugIndex = int.Parse(help[0]);
                int flyLength = int.Parse(help[2]);
                string direction = help[1];
                bool flag = false;

                int length = flyLength;
                switch (direction)
                {
                    case "right":
                        if (initialFields[ladybugIndex] == 1)
                        {
                            if (ladybugIndex + length > initialFields.Length - 1)
                            {
                                initialFields[initialFields.Length - 1] = 0;
                                break;
                            }

                            if (initialFields[ladybugIndex + length] == 0);
                            {
                                initialFields[ladybugIndex + length] = 1;
                            }

                            if (initialFields[ladybugIndex + length] == 1)
                            {
                                while (initialFields[ladybugIndex + length] == 1)
                                {
                                    length += flyLength;
                                    if (ladybugIndex + length > initialFields.Length - 1)
                                    {
                                        initialFields[initialFields.Length - 1] = 0;
                                        break;
                                    }
                                }
                                if (ladybugIndex + length <= initialFields.Length - 1)
                                {
                                    flag = true;
                                }

                                if (flag)
                                {
                                  initialFields[ladybugIndex + length] = 1;
                                }
                                 break;
                            }

                           
                        }
                        break;
                    case "left":
                        if (initialFields[ladybugIndex] == 1)
                        {
                            if (ladybugIndex - length < 0)
                            {
                                initialFields[0] = 0;
                                break;
                            }

                            if (initialFields[ladybugIndex - length] == 0)
                            {
                                initialFields[ladybugIndex - length] = 1;
                            }else if (initialFields[ladybugIndex - length] == 1)
                            {
                                while (initialFields[ladybugIndex - length] == 1)
                                {
                                    length += flyLength;

                                    if (ladybugIndex - length < 0)
                                    {
                                        initialFields[0] = 0;
                                        break;
                                    }
                                }
                                if (ladybugIndex - length >= 0)
                                {
                                    flag = true;
                                }
                                if (flag)
                                {
                                    initialFields[ladybugIndex - length] = 1;
                                }
                            }


                        }

                        break;
                }
                initialFields[ladybugIndex] = 0;

                command = Console.ReadLine();
            }
            Console.Write(String.Join(" ", initialFields));
        }
    }
}
