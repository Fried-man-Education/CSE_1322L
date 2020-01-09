using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Frequency: ");
            int frequency = int.Parse(Console.ReadLine());
            Console.Write("Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.Beep(frequency, duration);
            int[] nums = new int[] { 1, 4, 13, 43, -25, 17, 22, -37, 29 };
            int[] data = new int[20];
            randFill(data);
            Console.WriteLine("nums: " + findLargest(nums));
            Console.WriteLine("data: " + findLargest(data));
            Console.WriteLine(string.Join(" ", data));
        }

        static int findLargest (int[] numArray)
        {
            int max = numArray[0];
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] > max)
                {
                    max = numArray[i];
                }
            }
            return max;
        }

        static void randFill (int[] numArray)
        {
            Random finder = new Random();
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = finder.Next(-100, 101);
            }
        }
    }
}
