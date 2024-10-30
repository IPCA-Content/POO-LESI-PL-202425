//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>30-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using System.Text;

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

    /// <summary>
    /// Generate Random Strings
    /// </summary>
    /// <param name="count"></param>
    /// <param name="length"></param>
    /// <returns>string[]</returns>
    public static string[] GenerateRandomStrings(int count, int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        string[] result = new string[count];

        for (int i = 0; i < count; i++)
        {
            StringBuilder sb = new StringBuilder(length);
            for (int j = 0; j < length; j++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }

            result[i] = sb.ToString();
        }

        return result;
    }
    #endregion
}