using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            foreach (var username in input)
            {
                bool isValid = false;
                if (username.Length >= 3 && username.Length <= 16)
                {
                    foreach (var letter in username)
                    {
                        if (!Char.IsLetterOrDigit(letter) && letter.ToString() != "-" && letter.ToString() != "_")
                        {
                            isValid = false;
                            break;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
