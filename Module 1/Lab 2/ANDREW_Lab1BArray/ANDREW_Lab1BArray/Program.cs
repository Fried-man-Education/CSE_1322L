using System;

namespace ANDREW_Lab1BArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 5, 0, 2, -1, 88, 78, 66, -6, -7 };
            int[] data = new int[10];
            Console.WriteLine("Enter array values:");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("#" + i +": ");
                data[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.Write("nums array: ");
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine("nums streak: " + LongestPositiveSeries(nums));
            Console.Write("data array: ");
            Console.WriteLine(string.Join(" ", data));
            Console.WriteLine("data streak: " + LongestPositiveSeries(data));
        }

        static int LongestPositiveSeries (int[] numArray)
        {
            int max = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                int length = 0;
                while (numArray[i + length] > 0)
                {
                    length++;
                    if (i + length >= numArray.Length)
                    {
                        break;
                    }
                }
                if (length > max)
                {
                    max = length;
                }
            }
            return max;
        }
    }
}
