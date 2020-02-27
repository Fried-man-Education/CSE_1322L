using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            Console.WriteLine("String is palindrome: " + palindromeCheck(Console.ReadLine()));
        }

        static bool palindromeCheck(string input)
        {
            if (input.Length <= 1)
            {
                return true;
            }
            else if (input[0] != input[input.Length - 1])
            {
                return false;
            }
            else
            {
                return palindromeCheck(input.Substring(1).Remove(input.Substring(1).Length - 1));
            }
        }
    }
}
