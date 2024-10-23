//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>23-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using System.Collections;
using System.Collections.Concurrent;

namespace Lesson_7
{
    /// <summary>
    /// Summary description for Lesson.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
            #region Collections
            
            #region Stack
            // 1. Stack
            // A Stack is a LIFO (Last In, First Out) collection,
            // meaning the last element added is the first one to be removed.
            //  Usage: Use when you need to access the most recently added item first.
            //  Common Methods:
            //      Push(T item): Adds an item to the top of the stack.
            //      Pop(): Removes and returns the item from the top.
            //      Peek(): Returns the top item without removing it.
            // Advantages:
            //      Simple and Efficient: Fast O(1) insertion and removal.
            //      Best for LIFO: Great for undo operations, call stacks, or expression evaluation.
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1); // Push 1
            myStack.Push(2); // Push 2
            Console.WriteLine($"Stack Pop: {myStack.Pop()}"); // Remove and return the top item (2)
            Console.WriteLine($"Stack Peek: {myStack.Peek()}"); // Peek at the top item (1, without removing)

            #endregion

            #region Queue

            // 2. Queue
            // A Queue is a FIFO (First In, First Out) collection, meaning the first element added is the first one to be removed.
            // 
            // Usage: Use when you need to process items in the order they were added.
            // Common Methods:
            // Enqueue(T item): Adds an item to the end.
            // Dequeue(): Removes and returns the item from the front.
            // Peek(): Returns the item at the front without removing it.
            // Advantages:
            //      FIFO Processing: Ideal for task scheduling, printer jobs, or breadth-first search.
            //      Efficient: Fast O(1) enqueue and dequeue operations.

            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1); // Add 1 to the queue
            myQueue.Enqueue(2); // Add 2 to the queue
            Console.WriteLine($"Queue Dequeue: {myQueue.Dequeue()}"); // Remove and return the first item (1)
            Console.WriteLine($"Queue Peek: {myQueue.Peek()}"); // Peek at the next item (2, without removing)
            
            #endregion

            #region PriorityQueue

            // 3. PriorityQueue (from .NET 6)
            // A PriorityQueue allows elements to be dequeued in order of their priority. It's a FIFO structure with priority levels.
            //
            //     Usage: Use when you need to process items based on priority rather than just the order of insertion.
            //     Common Methods:
            // Enqueue(TElement, TPriority): Adds an item with an associated priority.
            //     Dequeue(): Removes and returns the item with the highest priority.
            //     Peek(): Returns the item with the highest priority without removing it.
            // Advantages:
            // Flexible Priority System: Useful for scenarios like task scheduling where certain tasks have higher priority.
            //     Efficient Processing: Dequeue is based on priority, making it efficient for real-time processing.

            PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();
            priorityQueue.Enqueue("Low Priority", 2); // Lower number means higher priority
            priorityQueue.Enqueue("High Priority", 1);
            Console.WriteLine($"PriorityQueue Dequeue: {priorityQueue.Dequeue()}"); // Returns "High Priority"
            #endregion

            #region ArrayList

            // 6. ArrayList (See Slides POO_6_Collection page 16)
            // Is a resizable array implementation in C#.
            // It implements the List interface, allowing it
            // to store duplicate elements and maintain insertion order.

            // Key Characteristics of ArrayList:
            // Resizable Array: Automatically expands when elements are added beyond its initial capacity.
            // Random Access: Elements can be accessed in constant time with the get() method.
            // Ordered: Maintains the order of elements as they are inserted.
            // Allows Duplicates: Unlike sets, an ArrayList can contain duplicate elements.
            // Non-Synchronized: ArrayList is not thread-safe, so explicit synchronization is needed when accessed by multiple threads.
            // Common Methods:
            //      add(E e): Adds an element to the end of the list.
            //      get(int index): Returns the element at the specified position.
            //      set(int index, E element): Replaces the element at the specified position with the specified element.
            //      remove(int index): Removes the element at the specified position.
            //      size(): Returns the number of elements in the list.
            //      isEmpty(): Checks if the list is empty.
            //      contains(Object o): Checks if the list contains a specific element.
            //      clear(): Removes all the elements from the list.

            // Performance Considerations:
            // Access: O(1) for accessing elements by index.
            //     Insertion/Removal: O(n) in the worst case, as elements might need to be shifted when inserting/removing from non-end positions.
            //     Memory: Uses more memory than arrays due to the overhead of resizing and storing references.
            //     Overall, an ArrayList is ideal for scenarios where you need dynamic resizing and frequent read operations but may not be optimal for frequent insertions/removals at arbitrary positions.

            ArrayList arrayList = new ArrayList
            {
                new Person( "John", 12),
                new Person( "Lane", 23)
            };
            arrayList.Add(new Person("Ana", 44));
            foreach (Person person in arrayList)
            {
                Console.WriteLine($"Person: {person.Name}, age: {person.Age}");
            }
            arrayList.Sort();
            foreach (Person person in arrayList)
            {
                Console.WriteLine($"Person: {person.Name}, age: {person.Age}");
            }

            #endregion

            #endregion

            #region Dictionary

            #region Hashtable

            // 4. Hashtable
            // A Hashtable is a non-generic collection of key-value pairs,
            // where each key is unique, and values
            // are accessed based on the key. Unlike Dictionary<TKey, TValue>,
            // Hashtable stores both keys and values as objects (non-generic).
            //     Usage: Use when you need a key-value structure, but type safety is not a concern.
            // Common Methods:
            // Add(object key, object value): Adds a key-value pair.
            //     Remove(object key): Removes the element with the specified key.
            //     ContainsKey(object key): Checks if the collection contains the specified key.
            // Advantages:
            //      Key-Based Access: Provides quick lookups and retrieval using keys.
            //      Older Collection: Was widely used before Dictionary<TKey, TValue> became
            //      the standard. Offers O(1) average time complexity for lookups.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("1", "First");
            hashtable.Add("2", "Second");
            Console.WriteLine($"Hashtable value for key '1': {hashtable["1"]}");
            #endregion

            #region SortedList

            // 5. SortedList in C#
            // SortedList<TKey, TValue> is a collection that stores key-value pairs
            // in sorted order based on the keys. It is part of the System.Collections.Generic namespace in C#.
            // Here are the details about SortedList, including its features, usage, and performance characteristics.
            //
            //     Key Features of SortedList<TKey, TValue>
            // Sorted by Key: Automatically maintains the order of keys. When you add elements, they are sorted based on their keys.
            //     Unique Keys: Each key must be unique. Attempting to add a duplicate key will throw an exception.
            //     Key-Value Pair Storage: Stores both keys and their corresponding values, similar to a dictionary.
            //     Fast Lookups: Allows fast retrieval of values based on keys, with O(log n) lookup time due to its internal data structure.
            // Capacity Management: Automatically resizes when the number of elements exceeds its capacity.
            // Performance Characteristics
            // Time Complexity:
            //
            // Insertion: O(log n)
            // Lookup: O(log n)
            // Removal: O(log n)
            // Iteration: O(n)
            // Space Complexity: SortedList is more memory efficient
            // than SortedDictionary when the number of elements is
            // relatively small. It uses less memory because it stores
            // the keys and values in two separate arrays.
            //
            //     When to Use SortedList
            // When you need a collection of key-value pairs sorted by keys.
            //     When the number of elements is relatively small and memory usage is a concern.
            // When you need efficient retrieval based on keys but don’t require the full flexibility of a dictionary.
            //     Limitations
            //     Fixed Size: While it can resize automatically, if a
            //          large number of elements are frequently added and removed,
            //          it can be less efficient than a SortedDictionary.
            //     Only Supports Unique Keys: If duplicate keys are required,
            //          a different structure (like List<KeyValuePair<TKey, TValue>>) should be used.
            //     Non-Generic (for SortedList): If you’re using System.Collections
            //          namespace, it’s a non-generic collection.
            //          Use SortedList<TKey, TValue> for a generic version.

            SortedList<int, string> sortedList = new SortedList<int, string>
            {
                {1, "First"},
                {3, "Third"},
                {2, "Second"}
            };
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"SortedList Key: {kvp.Key}, Value: {kvp.Value}");
            }
            #endregion

            #region Dictionary

            // 6. Dictionary in C#
            // In C#, you can create a Dictionary using the Dictionary<TKey, TValue> class, where both the key and value types can be specified as string. This allows you to store key-value pairs where both the key and the value are of type string.
            //     String Dictionary in C#:
            // You can use Dictionary<string, string> to create a dictionary where both the keys and values are strings.
            // Key Methods of Dictionary<TKey, TValue>:
            // Add(key, value): Adds a key-value pair to the dictionary.
            //     Remove(key): Removes the value with the specified key.
            //     ContainsKey(key): Checks if a key exists in the dictionary.
            //     TryGetValue(key, out value): Tries to get the value associated with the key, returns true if successful.
            //     Count: Gets the number of key-value pairs in the dictionary.
            //     Clear(): Removes all elements from the dictionary.
            //     Performance Considerations:
            // Access Time: O(1) for retrieving, adding, or removing elements based on a key.
            //     Memory: Uses a hash table internally, so it may use more memory than a simple list.
            //     When to Use:
            // Use a Dictionary<string, string> when you need fast lookups
            // and flexible key-value associations.

            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {"1", "First"},
                {"2", "Second"}
            };
            Console.WriteLine($"Dictionary value for key '1': {dictionary["1"]}");
            #endregion

            #endregion
        }
    }
}