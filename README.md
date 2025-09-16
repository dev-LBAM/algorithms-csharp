# AlgorithmsCSharp

A collection of algorithms implemented in **C#**, organized by category, with an **interactive console menu** for testing.

---

## 🗂 Project Structure

```plaintext
AlgorithmsCSharp/
├── Algorithms/
│   ├── Searching/       # Searching algorithms
│   │   ├── BinarySearch.cs
│   │   └── Recursion/   # Recursive searching examples
│   │       └── NestedBoxSearch.cs
│   └── Sorting/         # Sorting algorithms
│       └── SelectionSort.cs
├── Program.cs           # Main interactive console program
└── README.md
```

---

## 🎯 Interactive Menu

The project uses a console menu to navigate through algorithms:

### Main Menu
``` bash
1 - Searching
2 - Sorting
0 - Exit
```

### Searching Menu
```bash
1 - Binary Search
2 - Nested Box Search (Recursive & Iterative)
0 - Back to menu
```

### Sorting Menu
```bash
1 - Selection Sort
0 - Back to menu
```

> Invalid inputs are handled gracefully, prompting the user to choose a valid option.

---

## 🚀 How to Run

### 1. Clone the repository:
```bash
git clone https://github.com/dev-LBAM/algorithms-csharp.git
cd algorithms-csharp
```

### 2. Open the project in Visual Studio or VS Code.

### 3. Build and run the project:
```bash
dotnet run --project algorithmscsharp
```

---

## ➕ How to Add New Algorithms

### 1. Create a new .cs file inside the appropriate folder (Searching, Sorting, etc...).
### 2. Implement your algorithm as a static class with a Run() method.
### 3. Import the new algorithm in Program.cs: Use `using AlgorithmsCSharp.Algorithms.<YourFolder>;` to import the algorithm.
### 4. Add it to the corresponding menu inside ShowSearchingMenu() or ShowSortingMenu().

---

## 📚 Learning Goals

* Understand fundamental algorithmic concepts such as time and space complexity.

* Implement classic algorithms in C#, including:
    * Recursion
    * Linear and binary search
    * Sorting (bubble sort, merge sort, quicksort, etc.)

* Develop problem-solving skills and logical thinking applied to programming.

* Understand when and why to use each algorithm, comparing efficiency and applicability.

---

## 🧑‍💻 Author  
Lucas Batista de Almeida Moro  
https://github.com/dev-LBAM