using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AlgorithmsCSharp.Algorithms.Recursion
{
    public static class NestedBoxSearch
    {
        public static void Run()
        {
            Console.Clear();

            List<object> boxes =
            [
                0,
                new List<object> { 0, 0, new List<object> {1} },
                0
            ];

            while (true)
            {
                
                Console.WriteLine("== Nested Box Search ==");
                Console.WriteLine("1 - Iterative search");
                Console.WriteLine("2 - Recursive search");
                Console.WriteLine("0 - Back to Searching Algorithms menu");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine()!.ToLower();

                if (choice == "0")
                {
                    Console.Clear();
                    break;
                }
                
                Stopwatch stopwatch = Stopwatch.StartNew();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        bool result = SearchKeyIterative(boxes);
                        stopwatch.Stop();
                        if (!result) Console.WriteLine("Key not found (Iterative)");
                        Console.WriteLine($"\nIterative search completed in {stopwatch.Elapsed.TotalMilliseconds} ms.");
                        Console.WriteLine("Comment: In the iterative approach, we can manually manipulate the stack and process boxes as we want, giving more control over memory.\n");
                        break;

                    case "2":
                        Console.Clear();
                        bool result2 = SearchKeyRecursive(boxes);
                        stopwatch.Stop();
                        if (!result2) Console.WriteLine("Key not found (Recursive)");
                        Console.WriteLine($"\nRecursive search completed in {stopwatch.Elapsed.TotalMilliseconds} ms.");
                        Console.WriteLine("Comment: In the recursive approach, each call goes automatically into the system stack and we solve one box at a time. Cleaner code, but less flexible with memory.\n");
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Please choose 1, 2, or 0.");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        private static bool SearchKeyIterative(List<object> boxes)
        {
            Stack<List<object>> stack = new();
            stack.Push(boxes);
            while (stack.Count > 0)
            {
                List<object> currentBox = stack.Pop();

                foreach (var item in currentBox)
                {
                    if (item is int key && key == 1)
                    {
                        Console.WriteLine("Key found (Iterative)!");
                        return true;
                    }
                    else if (item is List<object> subBox)
                    {
                        Console.WriteLine("Found a sub-box, adding to stack...");
                        stack.Push(subBox);
                    }
                    else
                    {
                        Console.WriteLine("Nothing here, moving on...");
                    }
                }
            }

            return false;
        }

        private static bool SearchKeyRecursive(List<object> boxes, int depth = 0)
        {
            foreach (var item in boxes)
            {
                if (item is int key && key == 1)
                {
                    Console.WriteLine(new string(' ', depth * 2) + "Key found (Recursive)!");
                    return true;
                }
                else if (item is List<object> subBox)
                {
                    Console.WriteLine(new string(' ', depth * 2) + "Found a sub-box, opening...");
                    bool found = SearchKeyRecursive(subBox, depth + 1);
                    if (found) return true;
                }
                else
                {
                    Console.WriteLine(new string(' ', depth * 2) + "Nothing here, moving on...");
                }
            }

            return false;
        }
    }
}
