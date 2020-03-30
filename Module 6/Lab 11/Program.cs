using System;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a time in 24-hour format: ");
                string userInput = Console.ReadLine();
                if (userInput.Length <= 1)
                {
                    new TimeException("No input entered, try again.");
                    Console.WriteLine();
                    continue;
                }
                string[] data = userInput.Split(':');
                if (data.Length == 1) {
                    new TimeException("Missing semicolon, try again.");
                    Console.WriteLine();
                    continue;
                }
                if (int.Parse(data[0]) < 0 || int.Parse(data[0]) > 24)
                {
                    new TimeException("The number of hours was not valid, try again.");
                    Console.WriteLine();
                    continue;
                }
                if (int.Parse(data[1]) < 0 || int.Parse(data[1]) > 59)
                {
                    new TimeException("The number of minutes was not valid, try again.");
                    Console.WriteLine();
                    continue;
                }

                int hours = int.Parse(data[0]) % 12;
                if (int.Parse(data[0]) == 0 || hours == 0)
                {
                    hours = 12;
                }
                if (int.Parse(data[0]) > 11)
                {
                    Console.WriteLine("Same time in 12-hour format: " + hours + ":" + data[1] + " PM");
                }else
                {
                    Console.WriteLine("Same time in 12-hour format: " + hours + ":" + data[1] + " AM");
                }

                Console.Write("Continue? ");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "n")
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Program has finished!");
        }
    }

    class TimeException : Exception
    {
        public TimeException(string input)
        {
            Console.WriteLine(input);
        }
    }
}
