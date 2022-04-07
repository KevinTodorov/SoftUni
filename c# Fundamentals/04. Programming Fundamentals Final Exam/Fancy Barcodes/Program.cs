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
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string num = string.Empty;
                    bool flag = false;
                    string matchedBarcode = match.Groups["barcode"].Value;

                    foreach (var charachter in matchedBarcode)
                    {
                        if (Char.IsDigit(charachter))
                        {
                            num += charachter;
                            flag = true;
                        }
                    }

                    if (flag)
                    {
                        Console.WriteLine($"Product group: {num}");
                    }
                    else Console.WriteLine($"Product group: 00");
                }
                else Console.WriteLine("Invalid barcode");
            }
        }
    }
}
