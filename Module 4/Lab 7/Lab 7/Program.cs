using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            Console.WriteLine("Amount of vowels: " + vowelCount(Console.ReadLine()));
        }

        static int vowelCount (string input)
        {
            if (input.Length == 0)
            {
                return 0;
            }
            foreach (char x in "aeiou")
            {
                if (input[0] == x)
                {
                    return 1 + vowelCount(input.Substring(1));
                }
            }
            return vowelCount(input.Substring(1));
        }
    }
}
