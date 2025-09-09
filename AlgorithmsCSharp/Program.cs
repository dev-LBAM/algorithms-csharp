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
                default: Console.WriteLine("Invalid Option!"); Pause(); break;
            }
        }
    }

    static void ShowSearchingMenu()
    {
        Console.Clear();
        Console.WriteLine("== Searching Algorithms ==");
        Console.WriteLine("1 - Binary Search");
        Console.WriteLine("0 - Back to menu");

        Console.Write("Choose an option: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1": BinarySearch.Run(); break;
            case "0": return;
            default: Console.WriteLine("Invalid Option!"); break;
        }
    }

    static void ShowSortingMenu()
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
            default: Console.WriteLine("Invalid Option!"); break;
        }
    }

    static void Pause()
    {
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}
