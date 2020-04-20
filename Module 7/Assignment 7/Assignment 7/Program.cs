using System;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int[] firstArray = new int[10000];
            int[] secondArray = new int[10000];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = new Random().Next();
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }
            // Task 2
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            firstArray = BubbleSort(firstArray);
            watch.Stop();
            Console.WriteLine($"Time for linear bubble sort:       {watch.ElapsedMilliseconds / 1000f} seconds");
            // Task 3
            watch.Reset();
            watch.Start();
            secondArray = ParallelBubbleSort(secondArray);
            watch.Stop();
            Console.WriteLine($"Time for parallel bubble sort:     {watch.ElapsedMilliseconds / 1000f} seconds");
        }

        static int[] BubbleSort(int[] arr) // sorts array via bubble sort
        {
            int temp;
            for (int a = 0; a <= arr.Length - 2; a++) // whole run by whole run
            {
                for (int b = 0; b <= arr.Length - 2; b++) // value by value
                {
                    if (arr[b] > arr[b + 1]) // if larger swap
                    {
                        temp = arr[b + 1];
                        arr[b + 1] = arr[b];
                        arr[b] = temp;
                    }
                }
            }
            return arr;
        }

        static int[] ParallelBubbleSort(int[] arr) // sorts array via bubble sort using multithreading
        {
            int temp;
            Parallel.For(0, arr.Length - 2, (a, state) => // whole run by whole run
            {
                Parallel.For(0, arr.Length - 2, (b, state2) => // value by value
                {
                    if (arr[b] > arr[b + 1]) // if larger swap
                    {
                        temp = arr[b + 1];
                        arr[b + 1] = arr[b];
                        arr[b] = temp;
                    }
                });
            });
            return arr;
        }
    }
}
