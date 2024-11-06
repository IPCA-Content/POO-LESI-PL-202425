//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>30-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson_8;

/// <summary>
/// Class Helper
/// </summary>
public static class Helper
{
    #region Methods.
    /// <summary>
    /// Process Data 
    /// </summary>
    /// <param name="buffer"></param>
    /// <param name="bytesRead"></param>
    public static void ProcessData(byte[] buffer, int bytesRead)
    {
        // Handle the buffer data here (e.g., processing or storing)
        Console.WriteLine($"Read {bytesRead} bytes");
    }
    #endregion
}