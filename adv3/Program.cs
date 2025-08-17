using static System.Formats.Asn1.AsnWriter;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.PortableExecutable;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Linq.Expressions;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Reflection.Metadata;


namespace adv3
{



    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            #region 1.List<T>
            //  Structure:

            //   A generic, dynamic array that can grow or shrink in size as needed.
            //   Internally uses a contiguous memory allocation to store elements.
            //Time Complexity:

            //Access by index: O(1).
            //  Insert / remove at the end: O(1) amortized.
            //  Insert / remove in the middle: O(n).
            //Searching: O(n).
            //Business Case:

            //Use when the data order is important, and random access by index is required.
            //Examples: Managing a product list in an e-commerce system or storing user inputs in a form.
            // Example: Managing a list of products
            //Ex:---------


            //List<string> products = new List<string> { "Laptop", "Smartphone", "Tablet" };

            //Console.WriteLine("Product List:");
            //foreach (string product in products)
            //{
            //    Console.WriteLine(product);
            //}

            //// Adding and removing items
            //products.Add("Smartwatch");
            //products.Remove("Tablet");

            //Console.WriteLine("\nUpdated Product List:");
            //foreach (string product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #region 2.Dictionary<TKey, TValue>
            //        Structure:

            //  A collection of key-value pairs implemented as a hash table.
            //Keys are unique, and values can be accessed efficiently using the key.
            //Time Complexity:

            //Insert: O(1) average, O(n) worst -case due to rehashing.
            //        Search: O(1) average, O(n) worst -case.
            // Remove:
            //      O(1) average.
            //Business Case:

            //Ideal for scenarios requiring fast lookups and association of keys with values.
            //Examples: Caching user session data or mapping employee IDs to employee records.
            //Ex:---------


            //    Dictionary<int, string> employeeDirectory = new Dictionary<int, string>
            //{
            //    { 101, "Ali" },
            //    { 102, "Ahmed" },
            //    { 103, "Amr" }
            //};

            //    Console.WriteLine("Employee Directory:");
            //    foreach (var kvp in employeeDirectory)
            //    {
            //        Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            //    }

            //    // Searching for a key
            //    Console.WriteLine("\nSearch for Employee with ID 102:");
            //    if (employeeDirectory.TryGetValue(102, out string name))
            //    {
            //        Console.WriteLine($"Found: {name}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Employee not found.");
            //    }
            #region 3.HashSet<T>
            //   Structure:

            //        A collection of unique elements, implemented as a hash table.
            //Does not maintain order.
            //Time Complexity:

            //Add: O(1) average, O(n) worst -case.
            //Search:
            //           O(1) average, O(n) worst -case.
            //Remove:
            //           O(1) average.
            //Business Case:

            //Use when ensuring uniqueness is critical.
            //Examples: Managing user permissions or tracking visited pages in a web crawler
            //Ex:---------

            //     HashSet<string> permissions = new HashSet<string> { "Read", "Write", "Execute" };

            //Console.WriteLine("Initial Permissions:");
            //foreach (string permission in permissions)
            //{
            //    Console.WriteLine(permission);
            //}

            //// Adding duplicate and new permissions
            //permissions.Add("Write"); // Duplicate
            //permissions.Add("Delete");

            //Console.WriteLine("\nUpdated Permissions:");
            //foreach (string permission in permissions)
            //{
            //    Console.WriteLine(permission);
            //}
            #region 4.Queue<T>

            //        Structure:

            // A first-in, first -out (FIFO)collection.
            // Implemented as a circular array or linked list.
            //Time Complexity:

            //Enqueue(add): O(1).
            //Dequeue(remove): O(1).
            //Peek(retrieve front): O(1).
            //Business Case:

            //Useful in scenarios requiring sequential processing.
            //Examples: Job scheduling or managing print queues.
            //Ex:---------

            //Queue<string> printQueue = new Queue<string>();
            //printQueue.Enqueue("Document1.pdf");
            //printQueue.Enqueue("Document2.docx");
            //printQueue.Enqueue("Document3.xlsx");

            //Console.WriteLine("Print Queue:");
            //while (printQueue.Count > 0)
            //{
            //    Console.WriteLine($"Printing: {printQueue.Dequeue()}");
            //}
            #region 5.Stack<T>
            //   Structure:

            //   A last-in, first -out (LIFO)collection.
            //Typically implemented using an array or linked list.
            //Time Complexity:

            //Push(add): O(1).
            //Pop(remove): O(1).
            //Peek(retrieve top): O(1).
            //Business Case:
            //Suitable for managing undo-redo operations or evaluating expressions in compilers.
            //Ex:---------

            //Stack<string> undoStack = new Stack<string>();
            //undoStack.Push("Action1");
            //undoStack.Push("Action2");
            //undoStack.Push("Action3");

            //Console.WriteLine("Undo Stack:");
            //while (undoStack.Count > 0)
            //{
            //    Console.WriteLine($"Undo: {undoStack.Pop()}");
            //}
            #region 6.SortedList<TKey, TValue>
            //Structure:

            //A collection of key-value pairs sorted by keys.
            //Uses a combination of arrays and binary search for efficiency.
            //Time Complexity:

            //Add: O(log n) for insertion at the correct position.
            //Access by key: O(log n).
            //Remove: O(n).
            //Business Case:

            //Use when you need sorted data and fast lookups.
            //Examples: Maintaining a leaderboard or managing ordered stock prices.
            //Ex:---------

            //    SortedList<int, string> leaderboard = new SortedList<int, string>
            //{
            //    { 3, "Ali" },
            //    { 1, "Ahmed" },
            //    { 2, "Amr" }
            //};

            //    Console.WriteLine("Leaderboard (Sorted by Scores):");
            //    foreach (var kvp in leaderboard)
            //    {
            //        Console.WriteLine($"Rank: {kvp.Key}, Player: {kvp.Value}");
            //    }
            #region 7.SortedSet<T>

            // Structure:

            //A set that maintains elements in sorted order.
            //Internally implemented using a balanced binary search tree.
            //Time Complexity:

            //Add: O(log n).
            //            Search: O(log n).
            //            Remove: O(log n).
            //Business Case:

            //Best for unique, sorted elements.
            //Examples: Storing sorted keywords or tags in a document editor.
            //Ex:---------


            //SortedSet<string> keywords = new SortedSet<string> { "apple", "orange", "banana" };

            //Console.WriteLine("Sorted Keywords:");
            //foreach (string keyword in keywords)
            //{
            //    Console.WriteLine(keyword);
            //}

            //keywords.Add("cherry");
            //keywords.Add("apple"); 

            //Console.WriteLine("\nUpdated Sorted Keywords:");
            //foreach (string keyword in keywords)
            //{
            //    Console.WriteLine(keyword);
            //}














            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #endregion



            #region Part2
            #region Q1
            //int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            //Hashtable frequency = new Hashtable();

            //foreach (int number in numbers)
            //{
            //    if (frequency.ContainsKey(number))
            //        frequency[number] = (int)frequency[number] + 1; // Cast back to int
            //    else
            //        frequency[number] = 1;
            //}

            //Console.WriteLine("Frequency of elements:");
            //foreach (DictionaryEntry kvp in frequency)
            //{
            //    Console.WriteLine($"Element: {kvp.Key}, Frequency: {kvp.Value}");
            //}
            #region Q2
            //    Dictionary<string, int> hashTable = new Dictionary<string, int>
            //{
            //    { "key1", 5 },
            //    { "key2", 10 },
            //    { "key3", 8 }
            //};

            //    string maxKey = null;
            //    int maxValue = int.MinValue;

            //    foreach (var kvp in hashTable)
            //    {
            //        if (kvp.Value > maxValue)
            //        {
            //            maxValue = kvp.Value;
            //            maxKey = kvp.Key;
            //        }
            //    }

            //    Console.WriteLine($"Key with the highest value: {maxKey}");
            #region Q3
            //    Dictionary<string, string> hashTable = new Dictionary<string, string>
            //{
            //    { "key1", "apple" },
            //    { "key2", "banana" },
            //    { "key3", "apple" }
            //};

            //    string targetValue = "apple";
            //    List<string> resultKeys = new List<string>();

            //    foreach (var kvp in hashTable)
            //    {
            //        if (kvp.Value == targetValue)
            //            resultKeys.Add(kvp.Key);
            //    }

            //    if (resultKeys.Count > 0)
            //    {
            //        Console.WriteLine("Keys associated with the target value:");
            //        foreach (string key in resultKeys)
            //        {
            //            Console.WriteLine(key);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Key not found");
            //    }
            #region Q4
            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();

            //foreach (string word in words)
            //{
            //    string sortedWord = new string(word.OrderBy(c => c).ToArray());
            //    if (!groupedAnagrams.ContainsKey(sortedWord))
            //        groupedAnagrams[sortedWord] = new List<string>();

            //    groupedAnagrams[sortedWord].Add(word);
            //}

            //Console.WriteLine("Grouped Anagrams:");
            //foreach (var group in groupedAnagrams.Values)
            //{
            //    Console.WriteLine($"[{string.Join(", ", group)}]");
            //}
            #region Q5
            //int[] numbers = { 1, 2, 3, 4, 5, 2 };
            //HashSet<int> uniqueNumbers = new HashSet<int>();

            //bool hasDuplicates = false;
            //foreach (int number in numbers)
            //{
            //    if (!uniqueNumbers.Add(number))
            //    {
            //        hasDuplicates = true;
            //        break;
            //    }
            //}

            //Console.WriteLine(hasDuplicates ? "Array contains duplicates" : "Array does not contain duplicates");
            #region Q6
            //    SortedDictionary<int, string> students = new SortedDictionary<int, string>();

            //    // Add some initial students
            //    students.Add(101, "Ali");
            //    students.Add(103, "Amr");
            //    students.Add(102, "Ahmed");
            //    students.Add(104, "Sara");

            //    Console.WriteLine("Initial Students:");
            //    DisplayStudents(students);

            //    // Add a new student
            //    Console.WriteLine("\nAdding a new student (ID: 105, Name: Khaled):");
            //    students.Add(105, "Khaled");
            //    DisplayStudents(students);

            //    // Remove a student
            //    Console.WriteLine("\nRemoving a student with ID: 102");
            //    if (students.Remove(102))
            //    {
            //        Console.WriteLine("Student removed successfully.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Student not found.");
            //    }
            //    DisplayStudents(students);

            //    // Retrieve a student's name by ID
            //    Console.WriteLine("\nRetrieving a student's name by ID: 103");
            //    if (students.TryGetValue(103, out string studentName))
            //    {
            //        Console.WriteLine($"Student with ID 103: {studentName}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Student ID not found.");
            //    }
            //}
            //public static void DisplayStudents(SortedDictionary<int, string> students)
            //{
            //    Console.WriteLine("Student List (Sorted by ID):");
            //    foreach (var student in students)
            //    {
            //        Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            //    }
            #region Q7
            //    SortedList<int, string> employeeDirectory = new SortedList<int, string>
            //{
            //    { 3, "Ali" },
            //    { 1, "Sara" },
            //    { 2, "Amr" }
            //};

            //    Console.WriteLine("Employee Directory:");
            //    foreach (var employee in employeeDirectory)
            //    {
            //        Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            //    }
            #endregion
            #region Q8
            //int[] numbers = { 1, 3, 4, 6 };
            //int n = 6;

            //HashSet<int> numberSet = new HashSet<int>(numbers);
            //List<int> missingNumbers = new List<int>();

            //for (int i = 1; i <= n; i++)
            //{
            //    if (!numberSet.Contains(i))
            //        missingNumbers.Add(i);
            //}

            //Console.WriteLine("Missing Numbers:");
            //Console.WriteLine(string.Join(", ", missingNumbers));

            #endregion
            #region Q9
            //List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            //Console.WriteLine("Unique Values:");
            //foreach (int number in uniqueNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Q10
            //    Hashtable originalTable = new Hashtable
            //{
            //    { "One", 1 },
            //    { "Two", 2 },
            //    { "Three", 3 }
            //};

            //    // Create a new hashtable with swapped keys and values
            //    Hashtable swappedTable = new Hashtable();

            //    foreach (DictionaryEntry entry in originalTable)
            //    {
            //        swappedTable.Add(entry.Value, entry.Key);
            //    }

            //    // Print the swapped hashtable
            //    Console.WriteLine("Swapped Hashtable:");
            //    foreach (DictionaryEntry entry in swappedTable)
            //    {
            //        Console.WriteLine($"{entry.Key} : {entry.Value}");
            //    }
            #region Q11

            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            //HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

            //HashSet<int> unionSet = new HashSet<int>(set1);
            //unionSet.UnionWith(set2);

            //Console.WriteLine("Union of the two sets:");
            //foreach (int element in unionSet)
            //{
            //    Console.WriteLine(element);
            //}
            #region Q12
            Dictionary<string, int> dictionary = new Dictionary<string, int>
    {
        { "apple", 1 },
        { "animal", 2 },
        { "airport", 3 },
        { "banana", 4 },
        { "berry", 5 }
    };

            Console.Write("Enter the target character: ");
            char targetChar = Console.ReadLine()[0];

            int count = 0;
            foreach (string key in dictionary.Keys)
            {
                if (key.StartsWith(targetChar.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of keys starting with '{targetChar}': {count}");


            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
        }
    }
}