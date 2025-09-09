using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp.Algorithms.Sorting
{
    public static class SelectionSort
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("== Selection Sort ==");
            int[] unsortedArray = { 30, 3, 5, 7, 55, 11, 10, 15, 17, 1 };

            while (true)
            {
                Console.WriteLine($"Press any key to sorted the array: [{string.Join(", ", unsortedArray)}]");
                Console.ReadKey(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                int[] sortedArray = PerformSelectionSortSearch(unsortedArray);
                stopwatch.Stop();

                Console.WriteLine($"Sorted Array: [{string.Join(", ", sortedArray)}]");
                Console.Write($"Sorting completed in {stopwatch.Elapsed.TotalMilliseconds} ms.\n");
                

                Console.Write("Do you want to test Selection Sort again? (y/n): ");
                if (Console.ReadLine()?.ToLower() != "y")
                {
                    break;
                }
            }

        }

        private static int[] PerformSelectionSortSearch(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (array[i], array[minIndex]) = (array[minIndex], array[i]);
            }
            return array;
        }
    }
}
