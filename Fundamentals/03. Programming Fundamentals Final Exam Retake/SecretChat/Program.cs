using System;
using System.Linq;
using System.Text;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] inputInArray = input.Split(":|:").ToArray();
                string action = inputInArray[0];

                switch (action)
                {
                    case "InsertSpace":
                    {
                            int index = int.Parse(inputInArray[1]);
                            if (index >= 0 && index < word.Length)
                            {
                                StringBuilder stringBuilder = new StringBuilder(word);
                                stringBuilder = stringBuilder.Insert(index, " ");
                                word = stringBuilder.ToString();
                            }

                            Console.WriteLine(word);
                    }
                        break;
                    case "Reverse":
                    {
                        string substring = inputInArray[1];
                        StringBuilder stringBuilder = new StringBuilder(word);

                        if (stringBuilder.ToString().Contains(substring))
                        {
                            string reversedSubstring = string.Empty;
                            for (int i = substring.Length - 1; i >= 0; i--)
                            {
                                reversedSubstring += substring[i];
                            }

                            int firstIndex = word.IndexOf(substring);
                            stringBuilder = stringBuilder.Remove(firstIndex, substring.Length);
                            stringBuilder = stringBuilder.Append(reversedSubstring);
                            word = stringBuilder.ToString();
                            Console.WriteLine(word);
                        }else Console.WriteLine("error");
                        
                    }
                        break;
                    case "ChangeAll":
                    {
                        string substring = inputInArray[1];
                        string replacement = inputInArray[2];
                        StringBuilder stringBuilder = new StringBuilder(word);
                        stringBuilder = stringBuilder.Replace(substring, replacement);
                        word = stringBuilder.ToString();
                        Console.WriteLine(word);
                    }
                        break;

                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {word}");
        }
    }
}
