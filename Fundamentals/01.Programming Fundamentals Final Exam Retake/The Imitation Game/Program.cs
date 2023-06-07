using System;
using System.Linq;
using System.Text;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandInArray = command.Split("|").ToArray();
                string action = commandInArray[0];

                switch (action)
                {
                    case "Move":
                    {
                        int times = int.Parse(commandInArray[1]);
                        string temp = string.Empty;
                        StringBuilder sbBuilder = new StringBuilder(encryptedMessage);

                        for (int i = 0; i < times; i++)
                        {
                            temp += sbBuilder[0];
                            sbBuilder.Remove(0, 1);
                        }

                        sbBuilder.Append(temp);
                        encryptedMessage = sbBuilder.ToString();
                    }
                        break;
                    case "Insert":
                    {
                        int index = int.Parse(commandInArray[1]);
                        string value = commandInArray[2];
                        StringBuilder sbBuilder = new StringBuilder(encryptedMessage);
                        sbBuilder.Insert(index, value);
                        encryptedMessage = sbBuilder.ToString();
                    }
                        break;
                    case "ChangeAll":
                    {
                        string substring = commandInArray[1];
                        string replacement = commandInArray[2];
                        StringBuilder sbBuilder = new StringBuilder(encryptedMessage);
                        sbBuilder.Replace(substring, replacement);
                        encryptedMessage = sbBuilder.ToString();
                    }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
