using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList userInts = new ArrayList();
            Console.Write("Amount of numbers: ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write(" Number #" + (i + 1) + ": ");
                userInts.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Sum: " + SumList(userInts));

            LinkedList<int> userMoreInts = new LinkedList<int>();
            Console.Write("Amount of numbers: ");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write(" Number #" + (i + 1) + ": ");
                userMoreInts.AddLast(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Sum: " + SumLinked(userMoreInts));
        }

        static int SumList (ArrayList inputList)
        {
            int sum = 0;
            foreach (int x in inputList) sum += x;
            return sum;
        }

        static int SumLinked (LinkedList<int> inputLinked)
        {
            int sum = 0;
            foreach (int x in inputLinked) sum += x;
            return sum;
        }
    }
}
