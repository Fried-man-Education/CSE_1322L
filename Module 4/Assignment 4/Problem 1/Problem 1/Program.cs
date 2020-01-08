using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            printString("Hello world!");
            printReverse("Hello world!");
        }

        static void printString(string input)
        {
            if (input.Length == 0)
            {
                Console.WriteLine();
            }else {
                Console.Write(input[0]);
                printString(input.Substring(1));
            }
        }

        static void printReverse(string input)
        {
            if (input.Length == 0)
            {
                Console.WriteLine();
            }else
            {
                Console.Write(input[input.Length - 1]);
                printReverse(input.Remove(input.Length - 1));
            }
        }
    }
}
