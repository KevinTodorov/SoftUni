using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            for (int i = 1; i <= numberOfPieces; i++)
            {
                string[] newPieces = Console.ReadLine().Split("|").ToArray();

                string pieceName = newPieces[0];
                string composer = newPieces[1];
                string key = newPieces[2];

                pieces.Add(pieceName, new List<string>());
                pieces[pieceName].Add(composer);
                pieces[pieceName].Add(key);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandInArray = command.Split("|").ToArray();

                string action = commandInArray[0];
                string piece = commandInArray[1];

                switch (action)
                {
                    case "Add":
                    {
                        string composer = commandInArray[2];
                        string key = commandInArray[3];

                        if (!pieces.ContainsKey(piece))
                        {
                            pieces.Add(piece, new List<string>());
                            pieces[piece].Add(composer);
                            pieces[piece].Add(key);
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }else Console.WriteLine($"{piece} is already in the collection!");
                    }
                        break;
                    case "Remove":
                    {
                        if (pieces.ContainsKey(piece))
                        {
                            pieces.Remove(piece); 
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                    }
                        break;
                    case "ChangeKey":
                    {
                        string newKey = commandInArray[2];

                        if (pieces.ContainsKey(piece))
                        {
                            pieces[piece][1] = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                    }
                        break;
                }
                command = Console.ReadLine();
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
