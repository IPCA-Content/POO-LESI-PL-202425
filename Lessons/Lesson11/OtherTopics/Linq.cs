//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>28-12-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson10;

/// <summary>
/// Class Linq
/// </summary>
public class Linq
{
    /// <summary>
    /// Run
    /// </summary>
    public static void Run()
    {
        #region 1. LINQ (Language Integrated Query)
        // LINQ allows you to query collections like arrays,
        // lists, or even databases using a SQL-like syntax.
        
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Use LINQ to filter even numbers
        IEnumerable<int> evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
        #endregion
        
        #region 2. Select the length of each word
        List<string> words = new List<string> { "apple", "banana", "cherry" };

        // Select the length of each word
        var wordLengths = words.Select(word => new { Word = word, Length = word.Length });

        Console.WriteLine("Word lengths:");
        foreach (var item in wordLengths)
        {
            Console.WriteLine($"{item.Word}: {item.Length}");
        }
        #endregion
        
        #region 3. Sorting (OrderBy and OrderByDescending)
        List<int> numbersList = new List<int> { 42, 12, 67, 34, 89 };

        // Sort numbers in descending order
        var sortedNumbers = numbersList.OrderByDescending(num => num);

        Console.WriteLine("Numbers in descending order:");
        foreach (var num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
        #endregion
        
        #region 4. Grouping (GroupBy Clause)
        List<string> fruits = new List<string> { "apple", "banana", "cherry", "apricot", "blueberry" };

        // Group fruits by their first letter
        var groupedFruits = fruits.GroupBy(fruit => fruit[0]);

        Console.WriteLine("Fruits grouped by first letter:");
        foreach (var group in groupedFruits)
        {
            Console.WriteLine($"Group {group.Key}:");
            foreach (var fruit in group)
            {
                Console.WriteLine($"  {fruit}");
            }
        }
        #endregion
        
        #region 5. Aggregation (Sum, Average, Count, Min, Max)
        List<int> numbersValues = new List<int> { 3, 7, 2, 8, 6 };

        // Perform various aggregate operations
        int sum = numbersValues.Sum();
        double average = numbersValues.Average();
        int count = numbersValues.Count();
        int min = numbersValues.Min();
        int max = numbersValues.Max();

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Count: {count}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");
        #endregion
    }
}