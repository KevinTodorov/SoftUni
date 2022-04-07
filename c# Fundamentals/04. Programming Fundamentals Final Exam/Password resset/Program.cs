using System;
using System.Text;

namespace Password_resset
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawPass = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandInArr = command.Split();
                string action = commandInArr[0];

                switch (action)
                {
                    case "TakeOdd":
                    {
                        string newPassword = string.Empty;

                        for (int i = 0; i < rawPass.Length; i++)
                        {
                            if (i % 2 != 0 && i != 0)
                            {
                                newPassword += rawPass[i];
                            }
                        }

                        rawPass = newPassword;
                        Console.WriteLine(rawPass);
                    }
                        break;
                    case "Cut":
                    {
                        int index = int.Parse(commandInArr[1]);
                        int lenght = int.Parse(commandInArr[2]);
                        StringBuilder sbBuilder = new StringBuilder(rawPass);
                        sbBuilder.Remove(index, lenght);
                        rawPass = sbBuilder.ToString();
                        Console.WriteLine(rawPass);
                    }
                        break;
                    case "Substitute":
                    {
                        string substring = commandInArr[1];
                        string substitute = commandInArr[2];

                        if (rawPass.Contains(substring))
                        {
                            StringBuilder sbBuilder = new StringBuilder(rawPass);
                            sbBuilder.Replace(substring, substitute);
                            rawPass = sbBuilder.ToString();
                            Console.WriteLine(rawPass);
                        }else Console.WriteLine("Nothing to replace!");
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {rawPass}");
        }
    }
}
