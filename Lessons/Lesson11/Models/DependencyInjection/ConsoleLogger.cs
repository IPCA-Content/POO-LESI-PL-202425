//-----------------------------------------------------------------

using Lesson10.Interfaces;

namespace Lesson10.Models;

/// <summary>
/// Class
/// </summary>
public class ConsoleLogger : ILogger
{
    #region Public Methods
    /// <summary>
    /// Log
    /// </summary>
    /// <param name="message"></param>
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
    #endregion
}