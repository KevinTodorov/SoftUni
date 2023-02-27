using System;

namespace Summer_outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            string clothes = "";
            string shoes = ""; 

            switch (partOfDay)
            {
                case "Morning":
                    if(degrees >= 10 && degrees <= 18)
                    {
                        clothes = "Sweatshirt";
                        shoes = "Sneakers";
                    }else if (degrees > 18 && degrees <= 24)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }else if (degrees >= 25)
                    {
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (degrees >= 25)
                    {
                        clothes = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees >= 25)
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;

            }
            Console.WriteLine($"It's {degrees} degrees, get your {clothes} and {shoes}.");
        }
    }
}

//Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");