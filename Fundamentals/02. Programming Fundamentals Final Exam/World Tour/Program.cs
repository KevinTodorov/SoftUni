using System;
using System.Linq;
using System.Text;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] commandInArr = command.Split(":").ToArray();
                string action = commandInArr[0];

                switch (action)
                {
                    case "Add Stop":
                    {
                        int index = int.Parse(commandInArr[1]);
                        string word = commandInArr[2];
                        StringBuilder sbBuilder = new StringBuilder(destination);
                        if (index >= 0 && index < destination.Length)
                        {
                            sbBuilder.Insert(index, word);
                        }

                        destination = sbBuilder.ToString();
                        Console.WriteLine(destination);
                    }
                        break;
                    case "Remove Stop":
                    {
                        int startIndex = int.Parse(commandInArr[1]);
                        int endIndex = int.Parse(commandInArr[2]);
                        StringBuilder sbBuilder = new StringBuilder(destination);
                        int lenght = (endIndex - startIndex) + 1;
                        if (startIndex >= 0 && startIndex < destination.Length && endIndex >= 0 && endIndex < destination.Length)
                        {
                            sbBuilder.Remove(startIndex, lenght);
                        }

                        destination = sbBuilder.ToString();
                        Console.WriteLine(destination);
                    }
                        break;
                    case "Switch":
                    {
                        string oldWord = commandInArr[1];
                        string newWord = commandInArr[2];
                        StringBuilder sbBuilder = new StringBuilder(destination);
                        sbBuilder.Replace(oldWord, newWord);
                        destination = sbBuilder.ToString();
                        Console.WriteLine(destination);
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destination}");
        }
    }
}
