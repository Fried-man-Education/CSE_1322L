using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findSum(new int[] { 5, 18, 4, 7, 11 }));
        }

        static int findSum (int[] input)
        {
            if (input.Length == 1)
            {
                return input[0];
            }
            int Sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                Sum += input[i];
            }
            int[] newInput = new int[input.Length - 1];
            for (int i = 1; i < input.Length; i++)
            {
                newInput[i - 1] = input[i];
            }
            Sum += findSum(newInput);
            return Sum;
        }
    }
}
