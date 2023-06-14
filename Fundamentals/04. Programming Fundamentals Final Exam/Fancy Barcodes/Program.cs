using System;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string pattern = @"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";

            for (int i = 0; i < lines; i++)
            {
                string word = Console.ReadLine();
                Match productMatch = Regex.Match(word, pattern);
                if (productMatch.Success)
                {
                    string productGroup = String.Empty;
                    bool productGroupIsValid = false;
                    for (int letterIndex = 0; letterIndex < productMatch.Value.Length; letterIndex++)
                    {
                        if (Char.IsDigit(productMatch.Value[letterIndex]))
                        {
                            productGroup += productMatch.Value[letterIndex].ToString();
                            productGroupIsValid = true;
                        }
                    }

                    if (productGroupIsValid)
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }else Console.WriteLine("Product group: 00");
                }else Console.WriteLine("Invalid barcode");
            }
        }
    }
}
