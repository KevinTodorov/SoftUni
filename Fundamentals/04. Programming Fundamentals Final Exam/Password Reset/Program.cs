using System;
using System.Text;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandInArray = command.Split();
                string action = commandInArray[0];

                switch (action)
                {
                    case "TakeOdd":
                    {
                        StringBuilder sbBuilder = new StringBuilder();
                        for (int i = 1; i < word.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sbBuilder.Append(word[i]);
                            }
                        }
                        word = sbBuilder.ToString();
                        Console.WriteLine(word);
                    }
                        break;
                    case "Cut":
                    {
                        int index = int.Parse(commandInArray[1]);
                        int lenght = int.Parse(commandInArray[2]);
                        StringBuilder sbBuilder = new StringBuilder(word);
                        sbBuilder.Remove(index, lenght);
                        word = sbBuilder.ToString();
                        Console.WriteLine(word);
                    }
                        break;
                    case "Substitute":
                    {
                        string substring = commandInArray[1];
                        string substitute = commandInArray[2];
                        StringBuilder sbBuilder = new StringBuilder(word);
                        if (sbBuilder.ToString().Contains(substring))
                        {
                            sbBuilder.Replace(substring, substitute);
                            Console.WriteLine(sbBuilder.ToString());
                        }
                        else Console.WriteLine("Nothing to replace!");

                        word = sbBuilder.ToString();
                    }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {word}");
        }
    }
}
