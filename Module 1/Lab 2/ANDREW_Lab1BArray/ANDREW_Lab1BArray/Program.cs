using System;

namespace ANDREW_Lab1BArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[5,5];
            Console.WriteLine("Enter array values:");
            for (int a = 0; a < data.GetLength(0); a++)
            {
                for (int b = 0; b < data.GetLength(1); b++)
                {
                    Console.Write("[" + a + ", " + b + "]: ");
                    data[a,b] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Length: " + LongestPositiveSeries(data));
        }

        static int LongestPositiveSeries (int[,] numArray)
        {
            int max = 0;
            for (int i = 0; i < numArray.GetLength(0); i++)
            {
                int counter = 1;
                for (int j = 1; j < numArray.GetLength(1); j++)
                {
                    if (numArray[i, j] == numArray[i, j - 1] + 1) counter++;
                    else
                    {
                        if (counter > max)
                            max = counter;
                        counter = 1;
                    }
                }
                if (counter > max)
                    max = counter;
            }
            return max;
        }
    }
}
