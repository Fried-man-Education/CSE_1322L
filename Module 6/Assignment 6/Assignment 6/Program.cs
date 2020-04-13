using System;
using System.IO;
using System.Text;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = AskUser("Please enter a text file name and location: ");
            if (!File.Exists(filePath)) // check if file exists
            {
                do
                {
                    Console.WriteLine("File does not exist. Try again.");
                    filePath = AskUser("Please enter a text file name and location: ");
                } while (!File.Exists(filePath));
            }

            string content = File.ReadAllText(filePath, Encoding.UTF8);

            string newFilePath = AskUser("Please enter a new file name and location: ");
            while (File.Exists(newFilePath))
            {
                Console.WriteLine("A file already exists with that name!");
                Console.Write("Would you like to overwrite it or enter a different name? (0 or 1) ");
                string response = Console.ReadLine();
                if (response == "1")
                {
                    newFilePath = AskUser("Please enter a new file name and location: ");
                }
                else
                {
                    Console.WriteLine("The file will be overwritten.");
                    break;
                }
            }

            FileStream copyFile = File.Create(newFilePath);
            copyFile.Write(new UTF8Encoding(true).GetBytes(content));
            Console.WriteLine("The File \"" + filePath + "\" has been copied to \"" + newFilePath + "\".");
        }

        static string AskUser(string output)
        {
            Console.Write(output);
            return Console.ReadLine();
        }
    }
}
