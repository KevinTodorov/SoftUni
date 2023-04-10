using System;

namespace PasswordValidator
{
    class Program
    {
        private static bool flagHelp;

        public static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int count = 0;           
            characters(password,count);
            lettersAndDigits(password, count);
            minDigits(password, count);
            if (flagHelp)
            {
                Console.WriteLine("Password is valid");
            }
        }

       public static void characters(string password, int count)
        {
            bool flag = false;
            if (password.Length  < 6 || password.Length  > 10)
            {
                flag = true;
            }

            if (flag)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else
            {
                flagHelp = true;
            }
             
           
        }
       public static void lettersAndDigits(string password, int count)
        {
            bool numFlag = false;
            bool badFlag = false;

            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];
                string help = c.ToString();
                
                if (help == "0" || help == "1" || help == "2" || help == "3" || help == "4" ||
                    help == "5" || help == "6" || help == "7" || help == "8" || help == "9")
                {
                    numFlag = true; 
                }
                

                if (c < 65 || c > 122)
                {
                    badFlag = true;
                    if (numFlag)
                    {
                        badFlag = false;
                        numFlag = false;
                    }
                    if (badFlag)
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        flagHelp = false;
                        return;
                    }
                }
                
            }
            flagHelp = true;

        }

      public  static void minDigits(string password, int count)
        {
            int counts = 0;                  

            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];
                string help = c.ToString();
                if (help == "0" || help == "1" || help == "2" || help == "3" || help == "4" ||
                    help == "5" || help == "6" || help == "7" || help == "8" || help == "9")
                {
                 counts++;
                }
            }
            if (counts < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                flagHelp = false;
                return;
            }
            else
            {
                flagHelp = true;
            }            
        }
    }
}
