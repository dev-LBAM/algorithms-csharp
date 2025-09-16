using AlgorithmsCSharp.Algorithms.Recursion;
using AlgorithmsCSharp.Algorithms.Searching;
using AlgorithmsCSharp.Algorithms.Sorting;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("== Algorithms ==");
            Console.WriteLine("1 - Searching");
            Console.WriteLine("2 - Sorting");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose an option: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1": ShowSearchingMenu(); break;
                case "2": ShowSortingMenu(); break;
                case "0": return;
                default: Console.WriteLine("\nInvalid option. Please choose 1, 2 or 0."); Pause(); break;
            }
        }
    }

    static void ShowSearchingMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("== Searching Algorithms ==");
            Console.WriteLine("1 - Binary Search");
            Console.WriteLine("2 - Nested Box Search (Recursive & Iterative)");
            Console.WriteLine("0 - Back to menu");

            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1": BinarySearch.Run(); break;
                case "2": NestedBoxSearch.Run(); break;
                case "0": return;
                default: Console.WriteLine("\nInvalid option. Please choose 1, 2 or 0."); Pause(); break;
            }
        }
    }


    static void ShowSortingMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("== Sorting Algorithms ==");
            Console.WriteLine("1 - Selection Sort");
            Console.WriteLine("0 - Back to menu");

            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1": SelectionSort.Run(); break;
                case "0": return;
                default: Console.WriteLine("\nInvalid option. Please choose 1 or 0."); Pause(); break;
            }
        }
    }

    static void Pause()
    {
        Console.WriteLine("Press enter to continue...");
        Console.ReadKey();
    }
}
