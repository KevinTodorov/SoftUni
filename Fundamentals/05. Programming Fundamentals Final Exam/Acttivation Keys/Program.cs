using System;
using System.Text;

namespace Acttivation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] commandInArr = command.Split(">>>");
                string action = commandInArr[0];

                switch (action)
                {
                    case "Contains":
                    {
                        string substring = commandInArr[1];
                        StringBuilder sbBuilder = new StringBuilder(rawActivationKey);

                        if (sbBuilder.ToString().Contains(substring)) Console.WriteLine($"{rawActivationKey} contains {substring}");
                        else Console.WriteLine("Substring not found!");

                    }
                        break;
                    case "Flip":
                    {
                        int startIndex = int.Parse(commandInArr[2]);
                        int endIndex = int.Parse(commandInArr[3]);

                        if (commandInArr[1] == "Upper")
                        {
                            StringBuilder sbBuilder = new StringBuilder(rawActivationKey);
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                string newLetter = sbBuilder[i].ToString().ToUpper();
                                sbBuilder[i] = char.Parse(newLetter);
                            }

                            rawActivationKey = sbBuilder.ToString();
                        }
                        else
                        {
                            StringBuilder sbBuilder = new StringBuilder(rawActivationKey);
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                string newLetter = sbBuilder[i].ToString().ToLower();
                                sbBuilder[i] = char.Parse(newLetter);
                            }

                            rawActivationKey = sbBuilder.ToString();
                        }

                        Console.WriteLine(rawActivationKey);
                    }
                        break;
                    case "Slice":
                    {
                        int startIndex = int.Parse(commandInArr[1]);
                        int endIndex = int.Parse(commandInArr[2]);
                        StringBuilder sbBuilder = new StringBuilder(rawActivationKey);
                        
                        sbBuilder = sbBuilder.Remove(startIndex , endIndex - startIndex);
                        
                        rawActivationKey = sbBuilder.ToString();
                        Console.WriteLine(rawActivationKey);
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
