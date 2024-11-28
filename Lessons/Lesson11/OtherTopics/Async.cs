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
/// Class Async
/// </summary>
public class Async
{
    #region Public Methods
    /// <summary>
    /// Run Task
    /// </summary>
    public async Task RunAsync()
    {
        Console.WriteLine("Fetching data...");
        string result = await FetchDataAsync();
        Console.WriteLine(result);
    }

    /// <summary>
    /// Simulates a time-consuming operation
    /// </summary>
    /// <returns></returns>
    static async Task<string> FetchDataAsync()
    {
        await Task.Delay(2000); // Simulate a 2-second delay
        return "Data fetched successfully!";
    }
    #endregion
}