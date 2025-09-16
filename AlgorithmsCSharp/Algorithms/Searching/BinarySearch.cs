using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp.Algorithms.Searching
{
    public static class BinarySearch
    {  
        public static void Run()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("== Binary Search ==");
                int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
                Console.WriteLine($"Sorted Array: [{string.Join(", ", sortedArray)}]");
                Console.Write("\nEnter a number to search for: ");
                if (int.TryParse(Console.ReadLine(), out int target)) // Validate input
                {
                    Console.Clear();
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    int index = PerformBinarySearch(sortedArray, target);
                    stopwatch.Stop();

                    if (index != -1)
                    {
                        Console.WriteLine($"Number {target} found at index {index} in the array [{string.Join(", ", sortedArray)}].");
                    }
                    else
                    {
                        Console.WriteLine($"Number {target} not found in the array [{string.Join(", ", sortedArray)}].");
                    }
                    Console.Write($"Search completed in {stopwatch.Elapsed.TotalMilliseconds} ms.\n");
                    Console.Write("\nDo you want to search for another number? (y/n): ");
                    if (Console.ReadLine()?.ToLower() != "y")
                    {
                        break;
                    }
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid integer.");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
        private static int PerformBinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    return mid; // Target found
                }
                else if (array[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }
            return -1; // Target not found
        }

    }
}
