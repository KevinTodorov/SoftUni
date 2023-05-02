using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLocation = Console.ReadLine().Split("\\");
            string[] fileNameAndPptx = fileLocation[fileLocation.Length - 1].Split(".");
            Console.WriteLine($"File name: {fileNameAndPptx[0]}");
            Console.WriteLine($"File extension: {fileNameAndPptx[1]}");
        }
    }
}
